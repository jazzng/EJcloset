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
    public partial class adminstockin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_stockin_click(object sender, EventArgs e)
        {
            stockin();
        }

        protected void txt_item_code_textchanged(object sender, EventArgs e)
        {
            loaditemdetails();
        }

        protected void btn_clear_click(object sender, EventArgs e)
        {
            txt_item_code.Text = string.Empty;
            ClearContent();
        }

        //INCREASE STOCK QUANTITY IN DATABASE
        private void stockin()
        {
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Inventories where item_code = '" + txt_item_code.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int quantity = Convert.ToInt32(ds.Tables[0].Rows[0]["item_quantity"].ToString());
                int newtotal = quantity + Convert.ToInt32(txt_item_quantity.Value.ToString());

                string query = "update [Inventories] set [item_quantity] = '" + newtotal + "' where [item_code] = @item_code";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_code", txt_item_code.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<script type='text/javascript'>alert('Stock In Successful');window.location='adminstockin.aspx';</script>");

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
                }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());
                }

        }


        private void ClearContent()
        {
            txt_item_title.Value = string.Empty;
            txt_item_price.Value = string.Empty;
            txt_item_category.Value = string.Empty;
            txt_item_supplier.Value = string.Empty;
            txt_item_quantity.Value = string.Empty;
        }
    }
}