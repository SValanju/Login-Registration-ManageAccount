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
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J3PUE9B;database=DcodeTech;integrated security=SSPI");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HiddenField1.Value = Request.QueryString["id"];
            }
            //usr.Text = Session["usrName"].ToString();
            try
            {
                if (HiddenField1.Value != "")
                {
                    //int id = Convert.ToInt32(Session["Userid"]);
                    int id = Convert.ToInt32(HiddenField1.Value);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("viewUsers", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@ID", id);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    con.Close();
                    usr.Text = dtbl.Rows[0]["username"].ToString();
                }
                else
                {
                    err.Visible = true;
                    Label1.Visible = false;
                    LinkButton1.Visible = false;
                    Response.AppendHeader("Refresh", "5;url=Login.aspx");
                }
                
                
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(HiddenField1.Value);
            Response.Redirect("ManageDetails.aspx?id=" + id);
        }
    }
}