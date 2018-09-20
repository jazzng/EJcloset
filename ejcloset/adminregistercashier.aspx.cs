using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
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
            register(txt_user_id.Value.ToString(), txt_user_fullname.Value.ToString(), txt_user_phone.Value.ToString(), txt_user_address.Value.ToString(), txt_user_email.Value.ToString(), txt_user_password.Value.ToString(), txt_user_password2.Value.ToString());
            }

        protected void btn_clear_click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void register(String userid, String username, String userphone, String useraddress, String useremail, String userpassword, String userpassword2)
        {
            if(PasswordVerify(userpassword, userpassword2) == true)
            {
                if (UserExistVerify(userid) == true)
                {
                    if(Regex.IsMatch(userphone, @"^\d+$") == true)
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
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('Invalid Phone Number');</script>");
                    }
                    
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('User ID Already Existed');</script>");
                }
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Password Not Matching');</script>");
            }
            

            
        }

        private Boolean UserExistVerify(String userid)
        {
            Boolean verify = false;
            try
            {
                con.Open();
                SqlCommand cmd_role = new SqlCommand("select count(*) from Users where user_id = '" + userid + "'", con);
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

        private Boolean PasswordVerify(String password, String password2)
        {
            Boolean verify = false;

            if (password.Equals(password2))
            {
                verify = true;
            }
            else
            {
                verify = false;
            }

            return verify;
        }
        
        private void ClearContent()
        {
            txt_user_id.Value = String.Empty;
            txt_user_fullname.Value = String.Empty;
            txt_user_phone.Value = String.Empty;
            txt_user_address.Value = String.Empty;
            txt_user_email.Value = String.Empty;
            txt_user_password.Value = String.Empty;
            txt_user_password2.Value = String.Empty;
        }
        
    }
}