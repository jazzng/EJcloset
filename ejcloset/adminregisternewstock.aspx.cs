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
    public partial class adminregisternewstock : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlload();
        }

        protected void btn_registeritem_click(object sender, EventArgs e)
        {
            registeritem();
        }

        private void ddlload()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Categories", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddl_item_category.DataSource = dt;
            ddl_item_category.DataTextField = "category_name";
            DataBind();
        }

        private void registeritem()
        {
            if (ItemExistVerify(txt_item_code.Value.ToString()) == true)
            {
                if (DecimalVerify(txt_item_price.Value.ToString()) == true)
                {
                    con.Open();
                    try
                    {
                        string query = "INSERT INTO Inventories (item_code, item_title, item_price, item_category, item_supplier, item_quantity) values (@item_code, @item_title, @item_price, @item_category, @item_supplier, @item_quantity)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@item_code", txt_item_code.Value.ToString());
                        cmd.Parameters.AddWithValue("@item_title", txt_item_title.Value.ToString());
                        cmd.Parameters.AddWithValue("@item_price", Math.Round(Convert.ToDecimal(txt_item_price.Value.ToString()), 2));
                        cmd.Parameters.AddWithValue("@item_category", ddl_item_category.Value.ToString());
                        cmd.Parameters.AddWithValue("@item_supplier", txt_item_supplier.Value.ToString());
                        cmd.Parameters.AddWithValue("@item_quantity", txt_item_quantity.Value.ToString());

                        cmd.ExecuteNonQuery();
                        Response.Write("<script type='text/javascript'>alert('Register Successful');window.location='adminregisternewstock.aspx';</script>");

                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.ToString());
                    }
                    con.Close();
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Invalid Price');</script>");
                }

            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Item Code Already Existed');</script>");
            }
            
        }

        private Boolean ItemExistVerify(String itemcode)
        {
            Boolean verify = false;
            try
            {
                con.Open();
                SqlCommand cmd_role = new SqlCommand("select count(*) from Inventories where item_code = '" + itemcode + "'", con);
                int count = Convert.ToInt32(cmd_role.ExecuteScalar().ToString());
                if (count > 0)
                {
                    verify = false;
                }
                else
                {
                    verify = true;
                }

            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            con.Close();

            return verify;
        }

        private Boolean DecimalVerify(String price)
        {
            Boolean verify = false;
            foreach (char ch in price)
            {
                if (!char.IsDigit(ch) && ch != '.')
                {
                    verify = false;
                }
                else
                {
                    verify = true;
                }

            }

            return verify;
        }
    }
}