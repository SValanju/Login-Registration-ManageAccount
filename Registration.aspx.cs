using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J3PUE9B;database=DcodeTech;integrated security=SSPI");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = fname.Text;
                string Lname = lname.Text;
                string Email = email.Text;
                string Uname = uname.Text;
                string Pass = pass.Text;

                string sql1 = "select username from loginRegistration where username='" + Uname + "'";
                string sql2 = "insert into loginRegistration(Fname, Lname, email, username, password) values('" + Fname + "', '" + Lname + "', '" + Email + "', '" + Uname + "', '" + Pass + "')";

                con.Open();

                if (uname.Text != "")
                {
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    SqlDataReader sdr = cmd1.ExecuteReader();
                    if (sdr.Read())
                    {
                        Label6.Text = "Username already exist! Try different userame.";
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        int status = cmd2.ExecuteNonQuery();
                        if (status > 0)
                        {
                            Label6.Text = "Registration Completed!";
                            Response.AppendHeader("Refresh", "3;Login.aspx");
                        }
                        else
                        {
                            Label6.Text = "Some error occurred! Try again!";
                        }
                    }
                }
                else
                {
                    Label6.Text = "Please enter all details!";
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}