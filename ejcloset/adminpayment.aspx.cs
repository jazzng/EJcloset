using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ejcloset
{
    public partial class adminpayment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_itemcode.Focus();
        }

        //FILL ITEM INTO DATATABLE WHEN ITEM CODE DETECTED
        protected void txt_itemcode_textchanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Inventories where item_code = '" + txt_itemcode.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Response.Write("<script type='text/javascript'>alert('Item Not Found');</script>");
                }
                else
                {
                    //www.youtube.com/watch?v=n-xkgVfZDdA

                    //Populating a DataTable from database.
                    DataTable dt = this.GetItemData();

                    //Building an HTML string.
                    StringBuilder html = new StringBuilder();

                    //Building the Data rows.
                    html.Append("<tbody>");
                    int num = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        html.Append("<tr>");
                        html.Append("<td>");
                        num = num + 1;
                        html.Append(num);
                        html.Append("</td>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            html.Append("<td>");
                            html.Append(row[column.ColumnName]);
                            html.Append("</td>");
                        }

                        html.Append("</tr>");
                    }

                    //Append the HTML string to Placeholder.
                    payment_item.Controls.Add(new Literal { Text = html.ToString() });
                  
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

        //Get Item Details From Database
        private DataTable GetItemData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT item_code, item_title, item_price FROM Inventories where item_code = '" + txt_itemcode.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private void print()
        {

        }
    }
}