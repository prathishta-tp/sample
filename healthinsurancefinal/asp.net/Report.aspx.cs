using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Report : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnReport_Click(object sender, EventArgs e)
    {

        string cs = ConfigurationManager.ConnectionStrings["healthinsuranceConnectionString1"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("insert into report values ('" + tbreportPolicyID.Text + "','" + ddquestion.SelectedValue.ToString() + "','" + tbComment.Text  + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
          

        }


        Response.Redirect("UserPortal.aspx");
    }



    
}