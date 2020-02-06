using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {


        try
        {


            string cs = ConfigurationManager.ConnectionStrings["healthinsuranceConnectionString1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into usertable values ('" + tbFirstName.Text + "','" + tbLastName.Text + "','" + tbEmail.Text + "','" + tbAge.Text + "','" + tbUserName.Text + "','" + tbMobile.Text + "','" + tbPassword.Text + "','" + tbConfirmPassword.Text + "','" + tbCity.Text + "','" + tbGender.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Session["firstname"] = tbFirstName.Text;
                Session["age"] = tbAge.Text;
                
            }


            Response.Redirect("ULogin.aspx");
        }
        catch
        {
            lblMsgUserNameShow.Text = "User Name Already Exists";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }





   
}