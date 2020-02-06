using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class userdetails : System.Web.UI.Page
{
    DateTime StartDate;
    DateTime EndDate;
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

        mycon = new SqlConnection("server=localhost\\SQLExpress;user ID = sa; password=password@1;database=healthinsurance");
        Label1.Text = Session["name"].ToString();
        string eno = "select * from usertable where username ='" + Session["name"] + "'";
        // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
        myadapter = new SqlDataAdapter(eno, mycon);
        myds = new DataSet();
        myadapter.Fill(myds, "usertable");

        int rc = myds.Tables["usertable"].Rows.Count;
        if (rc > 0)
        {
          
            Session["ID"] = myds.Tables["usertable"].Rows[0][0].ToString();
            tbFirstName.Text= myds.Tables["usertable"].Rows[0]["Firstname"].ToString();
            tbAge.Text = myds.Tables["usertable"].Rows[0]["age"].ToString();
            // = Session["ID"].ToString();

            string eno1 = "select * from policytable where userid='" + Session["ID"]+"'";

           // Label1.Text = Session["ID"].ToString();
            // SqlCommand cmd = new SqlCommand("select CusID, CusName from CusDetails where CusUserName='" + Session["name"] + "'", con);
            myadapter1 = new SqlDataAdapter(eno1, mycon);
            myds1 = new DataSet();
            myadapter1.Fill(myds1, "policytable");
            int rc1 = myds1.Tables["policytable"].Rows.Count;
             // Label1.Text = rc1.ToString();
            tbPolicyType.Text = rc1.ToString();
            if (rc1 > 0)
            {
                tbPolicyID.Text = myds1.Tables["policytable"].Rows[0]["policyID"].ToString();
                
              
                tbPolicyType.Text = myds1.Tables["policytable"].Rows[0]["policyType"].ToString();
                tbPeriod.Text = myds1.Tables["policytable"].Rows[0]["policyPeriod"].ToString();
                tbInsAmt.Text = myds1.Tables["policytable"].Rows[0]["insuredAmount"].ToString();
                tbCoIns.Text = myds1.Tables["policytable"].Rows[0]["coInsurance"].ToString();
                tbPremium.Text = myds1.Tables["policytable"].Rows[0]["premium"].ToString();
                tbPolEndDate.Text = myds1.Tables["policytable"].Rows[0]["policyEndDate"].ToString();
              //   = ;
               // = Session["age"].ToString();
                //tbLastName.Text = myds.Tables["usertable"].Rows[0]["lastname"].ToString();
               // tbGender.Text = myds.Tables["usertable"].Rows[0]["gender"].ToString();
               // tbEmail.Text = myds.Tables["usertable"].Rows[0]["email"].ToString();
               // tbAge.Text = myds.Tables["usertable"].Rows[0]["age"].ToString();
                tbUserName.Text = Session["name"].ToString();
                Session["polid"] = tbPolicyID.Text;
            }

           
        }
        


    }
}