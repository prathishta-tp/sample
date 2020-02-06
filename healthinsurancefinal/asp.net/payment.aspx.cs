using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class payment : System.Web.UI.Page
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
        lblWelcomeUser.Text = Session["name"].ToString();
        lblpremamount.Text = Session["prem"].ToString();
    }

   


    protected void btnbackToportal_Click(object sender, EventArgs e)
    {
        Session["name"] = lblWelcomeUser.Text;
        Response.Redirect("UserPortal.aspx");
    }


    protected void btnPayConfirm_Click1(object sender, EventArgs e)
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
                Session["polid"]= myds1.Tables["policytable"].Rows[0]["policyID"].ToString();

        }
        SqlCommand cmd = new SqlCommand("insert into payment(rpolicyid,cardholderName,amount) values('" + Session["polid"] + "','" + tbCardHolderName.Text + "','" + Session["prem"] + "')", mycon);
        mycon.Open();
        cmd.ExecuteNonQuery();
        lblpaysuccess.Text = "Payment Successful!";


    }




    //string cs = ConfigurationManager.ConnectionStrings["healthinsuranceConnectionString1"].ConnectionString;
    //using (SqlConnection con = new SqlConnection(cs))
    //{
    //    SqlCommand cmd = new SqlCommand("insert into payment(rpolicyid,cardholderName,amount) values('" + Session["polid"] + "','" + tbCardHolderName.Text + "','" + Session["prem"] + "')", con);
    //    con.Open();
    //    cmd.ExecuteNonQuery();
    //    lblpaysuccess.Text = "Payment Successful!";
    //}

}


