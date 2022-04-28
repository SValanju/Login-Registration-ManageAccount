using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J3PUE9B;database=DcodeTech;integrated security=SSPI");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = uname.Text;
                string password = pass.Text;

                string sql = "select * from loginRegistration where username='" + username + "' and password='" + password + "'; SELECT SCOPE_IDENTITY()";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    con.Close();
                    con.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    //Session["Userid"] = id;
                    //Response.Redirect("Home.aspx");
                    Response.Redirect("Home.aspx?id=" + id);
                }
                else
                {
                    Label4.Text = "Username or Password is incorrect!";
                }
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}