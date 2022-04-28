using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class ManageDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J3PUE9B;database=DcodeTech;integrated security=SSPI");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    HiddenField1.Value = Request.QueryString["id"];

                    if (HiddenField1.Value != "")
                    {
                        int id = Convert.ToInt32(HiddenField1.Value);
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("viewUsers", con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@ID", id);
                        DataTable dtbl = new DataTable();
                        sda.Fill(dtbl);
                        con.Close();
                        TextBox1.Text = dtbl.Rows[0]["Fname"].ToString();
                        TextBox2.Text = dtbl.Rows[0]["Lname"].ToString();
                        TextBox3.Text = dtbl.Rows[0]["email"].ToString();
                        TextBox4.Text = dtbl.Rows[0]["username"].ToString();
                        TextBox5.Text = dtbl.Rows[0]["password"].ToString();
                    }
                    else
                    {
                        form1.Visible = false;
                        err.Text = "Some error occurred! Please wait.";
                        Response.AppendHeader("Refresh", "5;url=Login.aspx");
                    }

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(HiddenField1.Value);
                string fname = TextBox1.Text;
                string lname = TextBox2.Text;
                string email = TextBox3.Text;
                string usrname = TextBox4.Text;
                string pass = TextBox5.Text;

                string sql = "update loginRegistration set Fname='" + fname + "', Lname='" + lname + "', email='" + email + "', username='" + usrname + "', password='" + pass + "' where id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (fname != "" && lname != "" && email != "" && usrname != "" && pass != "")
                {
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    con.Close();
                    if (status > 0)
                    {
                        msg.Text = "Record updated successfully!";
                        Response.AppendHeader("Refresh", "3;url=Home.aspx?id=" + id);
                    }
                    else
                    {
                        err.Text = "Some error occurred! Please wait.";
                        Response.AppendHeader("Refresh", "3;url=ManageDetails.aspx?id=" + id);
                    }
                }
                else
                {
                    err.Text = "Some error occurred! Please wait.";
                    Response.AppendHeader("Refresh", "3;url=ManageDetails.aspx?id=" + id);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(HiddenField1.Value);

                string sql = "delete from loginRegistration where id='" + id + "'";
                if (HiddenField1.Value != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int status = cmd.ExecuteNonQuery();
                    con.Close();
                    if (status > 0)
                    {
                        msg.Text = "Account deleted successfully!";
                        Response.AppendHeader("Refresh", "3;url=Login.aspx?id=" + id);
                    }
                    else
                    {
                        err.Text = "Some error occurred! Please wait.";
                        Response.AppendHeader("Refresh", "3;url=ManageDetails.aspx?id=" + id);
                    }
                }
                else
                {
                    err.Text = "Some error occurred!";
                    Response.AppendHeader("Refresh", "3;url=Login.aspx");
                }
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(HiddenField1.Value);
            Response.Redirect("Home.aspx?id=" + id);
        }
    }
}