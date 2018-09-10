using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejcloset
{
    public partial class adminregistercashier : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

            protected void btn_register_click (object sender, EventArgs e)
            {
                con.Open();
                try
                {

                string query = "INSERT INTO Users (user_id, user_name, user_phone, user_address, user_email, user_type, user_password) values (@user_id, @user_name, @user_phone, @user_address, @user_email, @user_type, @user_password)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user_id", txt_user_id.Value.ToString());
                cmd.Parameters.AddWithValue("@user_name", txt_user_fullname.Value.ToString());
                cmd.Parameters.AddWithValue("@user_phone", txt_user_phone.Value.ToString());
                cmd.Parameters.AddWithValue("@user_address", txt_user_address.Value.ToString());
                cmd.Parameters.AddWithValue("@user_email", txt_user_email.Value.ToString());
                cmd.Parameters.AddWithValue("@user_type", "cashier");
                cmd.Parameters.AddWithValue("@user_password", txt_user_password.Value.ToString());

                cmd.ExecuteNonQuery();
                    Response.Write("<script type='text/javascript'>alert('Register Successful');window.location='adminregistercashier.aspx';</script>");



                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.ToString());
                }
                con.Close();
            }
        
    }
}