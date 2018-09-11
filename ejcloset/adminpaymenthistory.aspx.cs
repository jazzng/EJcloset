using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace ejcloset
{
    public partial class adminpaymenthistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                LoadAllData();
                LoadCashData();
                LoadOnlineData();
                LoadCreditCardData();

            }           
            
        }

        //Load All Payment Data
        private void LoadAllData()
        {
            //Populating a DataTable from database.
            DataTable dt = this.GetAllData();

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Build div
            html.Append("<div role='tabpanel' class='tab-pane fade' id='all'>");
            html.Append("<div class='row clearfix'>");
            html.Append("<div class='col-lg-12 col-md-12 col-sm-12 col-xs-12'>");
            html.Append("<div class='card'>");
            html.Append("<div class='body'>");
            html.Append("<div class='table-responsive'>");

            //Table start.
            html.Append("<table class='table table-bordered table-striped table-hover dataTable js-exportable'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            html.Append("<th>No.</th>");
            html.Append("<th>Payment Method</th>");
            html.Append("<th>Issued By</th>");
            html.Append("<th>Payment Date</th>");
            html.Append("<th>Payment Time</th>");
            html.Append("<th>Payment Amount (RM)</th>");            
            html.Append("</tr>");
            html.Append("</thead>");

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
                foreach (DataColumn column in dt.Columns)  {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");                    
                }
                html.Append("</tr>");
            }
           

            //Table end.
            html.Append("</table>");

            //div end
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");

            //Append the HTML string to Placeholder.
            LoadAll.Controls.Add(new Literal { Text = html.ToString() });


        }

        //Load Cash Payment Data
        private void LoadCashData()
        {

                //Populating a DataTable from database.
                DataTable dt = this.GetCashData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Build div
                html.Append("<div role='tabpanel' class='tab-pane fade' id='cash'>");
                html.Append("<div class='row clearfix'>");
                html.Append("<div class='col-lg-12 col-md-12 col-sm-12 col-xs-12'>");
                html.Append("<div class='card'>");
                html.Append("<div class='body'>");
                html.Append("<div class='table-responsive'>");


                //Table start.
                html.Append("<table class='table table-bordered table-striped table-hover dataTable js-exportable'>");

                //Building the Header row.
                html.Append("<thead>");
                html.Append("<tr>");
                html.Append("<th>No.</th>");
                html.Append("<th>Payment Method</th>");
                html.Append("<th>Issued By</th>");
                html.Append("<th>Payment Date</th>");
                html.Append("<th>Payment Time</th>");
                html.Append("<th>Payment Amount</th>");
                html.Append("</tr>");
                html.Append("</thead>");

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
                html.Append("</tbody>");

                //Table end.
                html.Append("</table>");

                //div end
                html.Append("</div>");
                html.Append("</div>");
                html.Append("</div>");
                html.Append("</div>");
                html.Append("</div>");
                html.Append("</div>");

                //Append the HTML string to Placeholder.
                LoadCash.Controls.Add(new Literal { Text = html.ToString() });
            
        }

        //Load Online Payment Data
        private void LoadOnlineData()
        {

            //Populating a DataTable from database.
            DataTable dt = this.GetOnlineData();

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Build div
            html.Append("<div role='tabpanel' class='tab-pane fade' id='online'>");
            html.Append("<div class='row clearfix'>");
            html.Append("<div class='col-lg-12 col-md-12 col-sm-12 col-xs-12'>");
            html.Append("<div class='card'>");
            html.Append("<div class='body'>");
            html.Append("<div class='table-responsive'>");


            //Table start.
            html.Append("<table class='table table-bordered table-striped table-hover dataTable js-exportable'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            html.Append("<th>No.</th>");
            html.Append("<th>Payment Method</th>");
            html.Append("<th>Issued By</th>");
            html.Append("<th>Payment Date</th>");
            html.Append("<th>Payment Time</th>");
            html.Append("<th>Payment Amount</th>");
            html.Append("</tr>");
            html.Append("</thead>");

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
            html.Append("</tbody>");

            //Table end.
            html.Append("</table>");

            //div end
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");

            //Append the HTML string to Placeholder.
            LoadOnline.Controls.Add(new Literal { Text = html.ToString() });

        }

        //Load Credit Card Payment Data
        private void LoadCreditCardData()
        {

            //Populating a DataTable from database.
            DataTable dt = this.GetCreditCardData();

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Build div
            html.Append("<div role='tabpanel' class='tab-pane fade' id='creditcard'>");
            html.Append("<div class='row clearfix'>");
            html.Append("<div class='col-lg-12 col-md-12 col-sm-12 col-xs-12'>");
            html.Append("<div class='card'>");
            html.Append("<div class='body'>");
            html.Append("<div class='table-responsive'>");


            //Table start.
            html.Append("<table class='table table-bordered table-striped table-hover dataTable js-exportable'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            html.Append("<th>No.</th>");
            html.Append("<th>Payment Method</th>");
            html.Append("<th>Issued By</th>");
            html.Append("<th>Payment Date</th>");
            html.Append("<th>Payment Time</th>");
            html.Append("<th>Payment Amount</th>");
            html.Append("</tr>");
            html.Append("</thead>");

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
            html.Append("</tbody>");

            //Table end.
            html.Append("</table>");

            //div end
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");
            html.Append("</div>");

            //Append the HTML string to Placeholder.
            LoadOnline.Controls.Add(new Literal { Text = html.ToString() });

        }

        //Get All Payment Data From Database
        private DataTable GetAllData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT payment_method, issued_by, payment_date, payment_time, payment_amount FROM Payments"))
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

        //Get Cash Payment Data From Database
        private DataTable GetCashData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT payment_method, issued_by, payment_date, payment_time, payment_amount FROM Payments WHERE payment_method = 'CASH'"))
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

        //Get Online Payment Data From Database
        private DataTable GetOnlineData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT payment_method, issued_by, payment_date, payment_time, payment_amount FROM Payments WHERE payment_method = 'ONLINE'"))
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

        //Get Credit Card Payment Data From Database
        private DataTable GetCreditCardData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT payment_method, issued_by, payment_date, payment_time, payment_amount FROM Payments WHERE payment_method = 'CREDIT CARD'"))
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

    }
}