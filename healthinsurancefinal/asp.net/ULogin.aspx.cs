using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class ULogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUserLogin_Click(object sender, EventArgs e)
    {
        string cs;

        cs = ConfigurationManager.ConnectionStrings["healthinsuranceConnectionString1"].ConnectionString;

        using (SqlConnection mycon = new SqlConnection(cs))

        {

            SqlCommand cmd = new SqlCommand("select username,upassword from usertable where username='" + tbUserLogin.Text + "' and  upassword='" + tbUserPassword.Text + "'", mycon);

            mycon.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count != 0)

            {
               // Session["id"] = tbUserLogin.Text;
                Session["name"] = tbUserLogin.Text;
                lblLoginMessage.Text = "Login Successful";

            }

            else

            {

                lblLoginMessage.Text = "Invalid username or password";

            }

        }

        Response.Redirect("UserPortal.aspx");
    }

    protected void btnLoginCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}