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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
            }
        }

        protected void btn_login_click(object sender, EventArgs e)
        {
            login_(txt_userid.Value, txt_password.Value);
        }

        private void login_(String userid, String password)
        {
            String role = verify(userid, password);
            if (role == null)
            {
                Response.Write("<script>alert('Invalid Username or Password');</script>");
                cleartext();
            }
            else
            {
                string session_userid = userid.Replace(" ", "");
                Session["userid"] = session_userid;
                if (role.Equals("admin"))
                {
                    Response.Write("<script type='text/javascript'>alert('Login Successful');window.location='index.aspx';</script>");//ADMIN PAGE
                }
                else if (role.Equals("cashier"))
                {
                    Response.Write("<script type='text/javascript'>alert('Login Successful');window.location='index.aspx';</script>");//CASHIER PAGE

                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Invalid Response');</script>");//ERROR
                }


            }

        }

        private String verify(String userid, String password)
        {
            String role = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Users where user_id = '" + userid +
                "' and user_password = '" + password + "'", con);
            int user_count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (user_count > 0)
            {
                SqlCommand cmd_role = new SqlCommand("select count(*) from Users where user_type = 'admin'", con);
                int role_count = Convert.ToInt32(cmd_role.ExecuteScalar().ToString());
                if (role_count > 0)
                {
                    role = "admin";
                }
                else
                {
                    role = "cashier";
                }
            }
            else
            {
                role = null;   
            }
            con.Close();

            return role;
        }

        private void cleartext()
        {
            txt_userid.Value = string.Empty;
            txt_password.Value = string.Empty;
        }
    }
}