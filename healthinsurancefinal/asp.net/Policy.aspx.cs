using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Policy : System.Web.UI.Page
{
    SqlConnection mycon;
    SqlDataAdapter myadapter;
    SqlCommand mycmd;
    DataSet myds;
    static int clickStatus = 0;// avoide using static variables(use session variable)
    string eno;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        lblWelcomeUser.Text = Session["name"].ToString();
    }

    protected void ddagebuypolicy_SelectedIndexChanged(object sender, EventArgs e)
    {
        string pt = ddPolicyType.SelectedItem.Value.ToString();
        string per = ddPeriod.SelectedItem.Value.ToString();
        double ia = double.Parse(ddInsuredAmount.SelectedItem.Value);
        int ci = int.Parse(ddCoInsurance.SelectedItem.Value);
        double prem;
        if (ddagebuypolicy.SelectedValue == 20.ToString())
        {
            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }
            }  

        }
        else if(ddagebuypolicy.SelectedValue==40.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }
            }

        }
        else if(ddagebuypolicy.SelectedValue==60.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) +300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

        }
        else
        {

            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }

            else
            {
                 if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

        }
        lblPremiumAmount.Text = Convert.ToString(prem);
    }

    protected void ddPolicyType_SelectedIndexChanged(object sender, EventArgs e)
    {
        string pt = ddPolicyType.SelectedItem.Value.ToString();
        string per = ddPeriod.SelectedItem.Value.ToString();
        double ia = double.Parse(ddInsuredAmount.SelectedItem.Value);
        int ci = int.Parse(ddCoInsurance.SelectedItem.Value);
        double prem;


        if (ddagebuypolicy.SelectedValue == 20.ToString())
        {
            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 40.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 60.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

        }
        else
        {

            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

        }


        lblPremiumAmount.Text = Convert.ToString(prem);
    }

    protected void ddPeriod_SelectedIndexChanged(object sender, EventArgs e)
    {
        string pt = ddPolicyType.SelectedItem.Value.ToString();
        string per = ddPeriod.SelectedItem.Value.ToString();
        double ia = double.Parse(ddInsuredAmount.SelectedItem.Value);
        int ci = int.Parse(ddCoInsurance.SelectedItem.Value);
        double prem;
        if (ddagebuypolicy.SelectedValue == 20.ToString())
        {
            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 40.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 60.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

        }
        else
        {

            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

        }
        lblPremiumAmount.Text = Convert.ToString(prem);
    }



    protected void ddInsuredAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        string pt = ddPolicyType.SelectedItem.Value.ToString();
        string per = ddPeriod.SelectedItem.Value.ToString();
        double ia = double.Parse(ddInsuredAmount.SelectedItem.Value);
        int ci = int.Parse(ddCoInsurance.SelectedItem.Value);
        double prem;
        if (ddagebuypolicy.SelectedValue == 20.ToString())
        {
            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 40.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 60.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

        }
        else
        {

            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

        }
        lblPremiumAmount.Text = Convert.ToString(prem);
    }




    protected void ddCoInsurance_SelectedIndexChanged(object sender, EventArgs e)
    {
        string pt = ddPolicyType.SelectedItem.Value.ToString();
        string per = ddPeriod.SelectedItem.Value.ToString();
        double ia = double.Parse(ddInsuredAmount.SelectedItem.Value);
        int ci = int.Parse(ddCoInsurance.SelectedItem.Value);
        double prem;
        if (ddagebuypolicy.SelectedValue == 20.ToString())
        {
            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 100;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 100;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 100;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 100;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 40.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 200;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 200;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 200;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 200;
                        }
                    }

                }
            }

        }
        else if (ddagebuypolicy.SelectedValue == 60.ToString())
        {


            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 300;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 300;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 300;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 300;
                        }
                    }

                }
            }

        }
        else
        {

            if (pt == "accidental")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }
            else if (pt == "longterm")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

            else if (pt == "permanent")
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }

            }

            else
            {
                if (per == "oneyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 24) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 26) + 500;
                        }
                    }

                }
                else if (per == "threeyear")
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 36) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 38) + 500;
                        }
                    }

                }
                else
                {
                    if (ia == 200000)
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else if (ia == 300000)
                    {

                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }
                    else
                    {
                        if (ci == 1)
                        {
                            prem = ((ia - (ia * 0.5)) / 40) + 500;
                        }
                        else
                        {
                            prem = ((ia - (ia * 0.5)) / 42) + 500;
                        }
                    }

                }
            }

        }
        lblPremiumAmount.Text = Convert.ToString(prem);
    }


    protected void btnBuy_Click(object sender, EventArgs e)
    {
        int rc;
        mycon = new SqlConnection("server=localhost\\sqlexpress;user id=sa;password=password@1;database=healthinsurance");
        eno = "select id from usertable where username='" + Session["name"] + "'";//holds this sentence/query
        myadapter = new SqlDataAdapter(eno, mycon);//sends this query to db
        myds = new DataSet();//create new memory to hold the result of query
                             // mycon.Open();
        myadapter.Fill(myds, "usertable");//opens connection,fetchs result from db,closes connection,myds points to table in db n hence has all the values,it doesnt hold the address(idf does then it is connected model n anyone can access other data from db) stores result into "employee table"
        rc = myds.Tables["usertable"].Rows.Count;//dtemployee holds address of employee table in myds(dataset)
                                                 // lblMsg.Text = rc.ToString();

        if (rc > 0)
        {
            Session["ID"] = myds.Tables["usertable"].Rows[0][0].ToString();


        }



            string cs = ConfigurationManager.ConnectionStrings["healthinsuranceConnectionString1"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("insert into policytable (userid,cusName,cusAge,username,policyType,policyPeriod,insuredAmount,coInsurance,premium,policyStartDate,policyEndDate)  values ('" + Session["id"].ToString() + "','" + Session["firstname"].ToString() + "','" + Session["age"].ToString() + "','" +   Session["name"].ToString() + "','" + ddPolicyType.Text + "','" + ddPeriod.Text + "','" + ddInsuredAmount.Text + "','" + ddCoInsurance.Text + "','" + lblPremiumAmount.Text + "','" + DateTime.Now + "','" + DateTime.Now.AddYears(int.Parse(ddPeriod.SelectedItem.Value)) + "')", con);
            
            con.Open();
            cmd.ExecuteNonQuery();
        }
       
        Session["prem"] = lblPremiumAmount.Text;
        Session["name"] = lblWelcomeUser.Text;
        Response.Redirect("payment.aspx");
    }

   
}