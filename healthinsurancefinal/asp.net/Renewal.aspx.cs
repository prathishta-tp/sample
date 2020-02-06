using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Renewal : System.Web.UI.Page
{

    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUserLogin_Click(object sender, EventArgs e)
    {
        mycon = new SqlConnection("server=localhost\\SQLExpress;user ID = sa; password=password@1;database=healthinsurance");
        //Label1.Text = Session["name"].ToString();
        string eno = "insert into renewal(rpolicyid,renewdate) values ('" + tbPolicyID.Text + "','" + tbExtensionDate.Text + "')";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "renewal");

        Response.Redirect("UserPortal.aspx");

    }
   
}