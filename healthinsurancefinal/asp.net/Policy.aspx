<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Policy.aspx.cs" Inherits="Policy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
        <div class="container">
            <i class="fa fa-handshake-o" style="font-size:36px;color:white"></i><a class="navbar-brand" href="#">
                <b>HEALTH INSURANCE</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="lblWelcome" runat="server" Text="WELCOME"></asp:Label>
                 <asp:Label ID="lblWelcomeUser" runat="server"></asp:Label>

            </a> <button class="navbar-toggler navbar-toggler-right border-0" type="button" data-toggle="collapse" data-target="#navbar10">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbar10">
                 <ul class="navbar-nav ml-auto">
                </ul>
            </div>
        </div>
    </nav>


        <br />
        <br />


        <!--policies-->
        <h1><span class="badge badge-secondary">Select Below Requirements</span></h1>
 
        <div class="form-group col-md-6">
      <label >Age</label>
        <asp:DropDownList type="text" class="form-control" ID="ddagebuypolicy" runat="server" OnSelectedIndexChanged="ddagebuypolicy_SelectedIndexChanged">
            <asp:ListItem>Choose..</asp:ListItem>
            <asp:ListItem Value="20">0-20</asp:ListItem>
            <asp:ListItem Value="40">21-40</asp:ListItem>
            <asp:ListItem Value="60">41-60</asp:ListItem>
            <asp:ListItem Value="80">61 and Above</asp:ListItem>
        </asp:DropDownList>
        
    </div>
 
           <div class="form-group col-md-6">
      <label >Policy Type</label>
        <asp:DropDownList type="text" class="form-control" ID="ddPolicyType" runat="server" OnSelectedIndexChanged="ddPolicyType_SelectedIndexChanged">
            <asp:ListItem>Choose..</asp:ListItem>
            <asp:ListItem Value="accidental">Accidental Death & Dismemberment Insurance</asp:ListItem>
            <asp:ListItem Value="longterm">Long term care Insurance</asp:ListItem>
            <asp:ListItem Value="permanent">Total Permanent Disability Insurance</asp:ListItem>
            <asp:ListItem Value="disability">Disability Insurance</asp:ListItem>
        </asp:DropDownList>
        
    </div>
        
          
        <div class="form-group col-md-6">
      <label >Period</label>
        <asp:DropDownList type="text" class="form-control" ID="ddPeriod" runat="server" OnSelectedIndexChanged="ddPeriod_SelectedIndexChanged">
            <asp:ListItem>Choose..</asp:ListItem>
            <asp:ListItem Value="1">1 Year</asp:ListItem>
            <asp:ListItem Value="3">3 Year</asp:ListItem>
            <asp:ListItem Value="5">5 Year</asp:ListItem>
        </asp:DropDownList>
        
    </div>
 
 

    <div class="form-group col-md-6">
      <label >Insured Amount</label>
        <asp:DropDownList type="text" class="form-control" ID="ddInsuredAmount" runat="server" OnSelectedIndexChanged="ddInsuredAmount_SelectedIndexChanged">
            <asp:ListItem>Choose..</asp:ListItem>
            <asp:ListItem>200000</asp:ListItem>
            <asp:ListItem>300000</asp:ListItem>
            <asp:ListItem>500000</asp:ListItem>
        </asp:DropDownList>
        
    </div>



         <div class="form-group col-md-6">
      <label >Co-Insurance</label>
        <asp:DropDownList type="text" class="form-control" ID="ddCoInsurance" runat="server" OnSelectedIndexChanged="ddCoInsurance_SelectedIndexChanged">
            <asp:ListItem>Choose..</asp:ListItem>
            <asp:ListItem Value="1">10%</asp:ListItem>
            <asp:ListItem Value="2">20%</asp:ListItem>
        </asp:DropDownList>
    </div>

        <asp:Button type="button" class="btn btn-dark" ID="btnPremium" runat="server" Text="Query for Premium" />
    <div class="form-group col-md-6">
      <label >Premium/Year:</label>
        <asp:Label ID="lblPremiumAmount" runat="server" Text=""></asp:Label> &nbsp; &nbsp;
        <asp:Button type="button" class="btn btn-dark" ID="btnBuy" runat="server" Text="Buy" OnClick="btnBuy_Click" />

 </div>
 <%--<asp:Button type="button" class="btn btn-primary btn-lg " ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
  <asp:Button type="button" class="btn btn-danger btn-lg " ID="btnCancel" runat="server" Text="cancel" OnClick="btnCancel_Click" />--%>














             <!-- Footer -->
<footer class="page-footer font-small w3-dark-grey">

    <div style="background-color: black;">
        <div class="container">

            <!-- Grid row-->
            <div class="row py-4 d-flex align-items-center">

                <!-- Grid column -->
                <div class="col-md-6 col-lg-5 text-center text-md-left mb-4 mb-md-0">
                    <h6 class="mb-0">Get connected with us on social networks!</h6>
                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class="col-md-6 col-lg-7 text-center text-md-right">

                    <!-- Facebook -->
                    <a class="fb-ic">
                        <i class="fa fa-facebook-f white-text mr-4"> </i>
                    </a>
                    <!-- Twitter -->
                    <a class="tw-ic">
                        <i class="fa fa-twitter white-text mr-4"> </i>
                    </a>
                   <%-- <!-- Google +-->
                    <a class="gplus-ic">
                        <i class="fa fa-google-plus-g white-text mr-4"> </i>
                    </a>
                    <!--Linkedin -->
                    <a class="li-ic">
                        <i class="fa fa-linkedin-in white-text mr-4"> </i>
                    </a>--%>
                    <!--Instagram-->
                    <a class="ins-ic">
                        <i class="fa fa-instagram white-text"> </i>
                    </a>

                </div>
                <!-- Grid column -->

            </div>
            <!-- Grid row-->

        </div>
    </div>

    <!-- Footer Links -->
    <div class="container text-center text-md-left mt-5" style="background-color:black">

        <!-- Grid row -->
        <div class="row mt-3">

            <!-- Grid column -->
            <div class="col-md-3 col-lg-4 col-xl-3 mx-auto mb-4">

                <!-- Content -->
                <h6 class="text-uppercase font-weight-bold">Company name</h6>
                <hr class="deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto" style="width: 60px;">
                <p>
                    HEALTHPLUS
                </p>

            </div>
            <!-- Grid column -->
            <!-- Grid column -->
            <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">

                <!-- Links -->
                <h6 class="text-uppercase font-weight-bold">Doctors in Bangalore</h6>
                <hr class="deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto" style="width: 60px;">
                <p>
                    <a href="#!">Cardiologist</a>
                </p>
                <p>
                    <a href="#!">ENT Specialist</a>
                </p>
                <p>
                    <a href="#!">Gynaecologist</a>
                </p>
                <p>
                    <a href="#!">Nutritionist</a>
                </p>

            </div>
            <!-- Grid column -->
            <!-- Grid column -->
            <div class="col-md-3 col-lg-2 col-xl-2 mx-auto mb-4">

                <!-- Links -->
                <h6 class="text-uppercase font-weight-bold">Useful links</h6>
                <hr class="deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto" style="width: 60px;">
                <p>
                    <a href="#!">Your Account</a>
                </p>
                <p>
                    <a href="#!">Become an Affiliate</a>
                </p>
                <p>
                    <a href="#!">Shipping Rates</a>
                </p>
                <p>
                    <a href="#!">Help</a>
                </p>

            </div>
            <!-- Grid column -->
            <!-- Grid column -->
            <div class="col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4">

                <!-- Links -->
                <h6 class="text-uppercase font-weight-bold">Contact</h6>
                <hr class="deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto" style="width: 60px;">
                <p>
                    <i class="fa fa-home"></i> New York, NY 10012, US
                </p>
                <p>
                    <i class="fa fa-envelope-o"></i> info@example.com
                </p>
                <p>
                    <i class="fa fa-phone"></i> + 01 234 567 88
                </p>
                <p>
                    <i class="fa fa-print"></i> + 01 234 567 89
                </p>

            </div>
            <!-- Grid column -->

        </div>
        <!-- Grid row -->

    </div>
    <!-- Footer Links -->
    <!-- Copyright -->
    <div class="footer-copyright text-center py-3">
        © 2020 Copyright:
        <a href=""> All Rights Reserved</a>
    </div>
    <!-- Copyright -->

</footer>
<!-- Footer -->
    
    </form>
</body>
</html>
