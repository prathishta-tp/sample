using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class UserPortal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblWelcomeUser.Text = Session["name"].ToString();
    }

    protected void btnBuyPolicy_Click(object sender, EventArgs e)
    {

        Session["name"] = lblWelcomeUser.Text;
        Response.Redirect("Policy.aspx");
    }

   


  

    protected void btnClaim_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Claim.aspx");
    }

    protected void btnGridView_Click(object sender, EventArgs e)
    {
        Response.Redirect("userdetails.aspx");
    }

    protected void btnReport_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Report.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["name"] = null;
        Response.Redirect("home.aspx");
    }

    protected void btnRenewal_Click(object sender, EventArgs e)
    {
        Session["name"] = lblWelcomeUser.Text;
        Response.Redirect("Renewal.aspx");
    }
}