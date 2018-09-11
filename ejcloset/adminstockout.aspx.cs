using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejcloset
{
    public partial class adminstockout : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txt_item_code_textchanged(object sender, EventArgs e)
        {
            loaditemdetails();
        }

        protected void btn_stockout_click(object sender, EventArgs e)
        {
            if (ValidateItemCode() == 1)
            {
                stockout();
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Please Enter A Valid Item Code');</script>");
            }
        }
        protected void btn_clear_click(object sender, EventArgs e)
        {
            txt_item_code.Text = string.Empty;
            ClearContent();
        }

        //INCREASE STOCK QUANTITY IN DATABASE
        private void stockout()
        {
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Inventories where item_code = '" + txt_item_code.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int quantity = Convert.ToInt32(ds.Tables[0].Rows[0]["item_quantity"].ToString());
                int newquantity = Convert.ToInt32(txt_item_quantity.Value.ToString());
                int newtotal = quantity - newquantity;
                string formula = quantity + " - " + newquantity + " = " + newtotal;
                string query = "update [Inventories] set [item_quantity] = '" + newtotal + "' where [item_code] = @item_code";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_code", txt_item_code.Text);
                cmd.ExecuteNonQuery();

                Page.ClientScript.RegisterStartupScript(Type.GetType("System.String"), "STOCK IN SUCCESSFUL", "alert('Current Stock Quantity: " + formula + "');", true);

            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            con.Close();

            RecordStockInOut(); // insert record to DB
            txt_item_code.Text = string.Empty; //Clear item code textbox
            ClearContent(); //Clear textbox
        }

        //INSERT STOCKIN/OUT RECORD TO DATABASE
        private void RecordStockInOut()
        {
            con.Open();
            try
            {
                string query = "INSERT INTO StockInOut (item_code, item_title, item_initial_quantity, item_new_quantity, item_new_total, item_status, date, time) values (@item_code, @item_title, @item_initial_quantity, @item_new_quantity, @item_new_total, @item_status, @date, @time)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_code", txt_item_code.Text);
                cmd.Parameters.AddWithValue("@item_title", txt_item_title.Value.ToString());
                int existingquantity = Convert.ToInt32(txt_item_existing_quantity.Value.ToString());
                cmd.Parameters.AddWithValue("@item_initial_quantity", existingquantity );
                int newquantity = Convert.ToInt32(txt_item_quantity.Value.ToString()) - Convert.ToInt32(txt_item_quantity.Value.ToString()) * 2;
                cmd.Parameters.AddWithValue("@item_new_quantity", newquantity);
                int newtotal = existingquantity + newquantity;
                cmd.Parameters.AddWithValue("@item_new_total", newtotal);
                cmd.Parameters.AddWithValue("@item_status", "STOCK OUT");
                cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            con.Close();
        }

        //LOAD ITEM DETAILS WHEN ITEM CODE DETECTED
        private void loaditemdetails()
        {

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Inventories where item_code = '" + txt_item_code.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    ClearContent();
                }
                else
                {
                    txt_item_title.Value = ds.Tables[0].Rows[0]["item_title"].ToString();
                    txt_item_price.Value = ds.Tables[0].Rows[0]["item_price"].ToString();
                    txt_item_category.Value = ds.Tables[0].Rows[0]["item_category"].ToString();
                    txt_item_supplier.Value = ds.Tables[0].Rows[0]["item_supplier"].ToString();
                    txt_item_existing_quantity.Value = ds.Tables[0].Rows[0]["item_quantity"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }

        }

        //CLEAR CONTENT FROM EXCEPT ITEM CODE
        private void ClearContent()
        {
            txt_item_title.Value = string.Empty;
            txt_item_price.Value = string.Empty;
            txt_item_category.Value = string.Empty;
            txt_item_supplier.Value = string.Empty;
            txt_item_existing_quantity.Value = string.Empty;
            txt_item_quantity.Value = string.Empty;
        }

        //Validate Item Code Existence
        private int ValidateItemCode()
        {
            int validate = 0;
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Inventories where item_code = '" + txt_item_code.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    validate = 0;
                }
                else
                {
                    validate = 1;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }

            return validate;
        }
    }
}