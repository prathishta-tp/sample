using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class claim2 : System.Web.UI.Page
{
    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    SqlConnection mycon1;
    SqlDataAdapter myadapter1;
    SqlCommand mycmd1;
    DataSet myds1;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnclaim1_Click(object sender, EventArgs e)
    {
        mycon = new SqlConnection("server=localhost\\SQLExpress;user ID = sa; password=password@1;database=healthinsurance");
        // Label1.Text = Session["name"].ToString();
        string eno = "select * from usertable where username ='" + Session["name"] + "'";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "usertable");

        int rc = myds.Tables["usertable"].Rows.Count;
        if (rc > 0)
        {
            Session["cus_id"] = myds.Tables["usertable"].Rows[0]["id"].ToString();
        }
        string eno1 = "select * from policytable where userid='" + Session["cus_id"] + "'";
        myadapter1 = new SqlDataAdapter(eno1, mycon);
        myds1 = new DataSet();
        myadapter1.Fill(myds1, "policytable");
        int rc1 = myds1.Tables["policytable"].Rows.Count;

        if (rc1 > 0)
        {
            Session["polid"] = myds1.Tables["policytable"].Rows[0]["policyID"].ToString();
            Session["polType"]= myds1.Tables["policytable"].Rows[0]["policyType"].ToString();
            Session["period"] = myds1.Tables["policytable"].Rows[0]["policyPeriod"].ToString();
            Session["enddate"] = myds1.Tables["policytable"].Rows[0]["policyEndDate"].ToString();

        }
        SqlCommand cmd = new SqlCommand("insert into claim(cusid,polId,policyType,periodpol,polenddatee) values('"+Session["Cus_id"]+"','" + Session["polid"] + "','" + Session["polType"] + "','" + Session["period"]+"','" + Session["enddate"] + "')", mycon);
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        using (SqlCommand cmd1 = new SqlCommand("update claim set claim_status=@status where polId=@pid", mycon))
        {
           // cmd1.Connection.Open();
            cmd1.Parameters.AddWithValue("@status", "Availed");
            cmd1.Parameters.AddWithValue("@pid", Session["polid"]);
            cmd1.ExecuteNonQuery();
        }

            
      
        Response.Redirect("UserPortal.aspx");

    }
}