<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPortal.aspx.cs" Inherits="UserPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>



</head>
<body>
    <form id="form1" runat="server">
     <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
        <div class="container">
            <i class="fa fa-handshake-o" style="font-size:36px;color:white"></i><a class="navbar-brand" href="#">
                <b>HEALTH INSURANCE</b>&nbsp;&nbsp;
                       <asp:Button type="button" class="btn btn-dark" ID="btnBuyPolicy" runat="server" Text="Buy Policy" OnClick="btnBuyPolicy_Click" />

                
                         <asp:Button type="button" class="btn btn-dark" ID="btnUserdetails" runat="server" Text="View your details" OnClick="btnGridView_Click" />

                
                                                <asp:Button type="button" class="btn btn-dark" ID="btnClaim" runat="server" Text="Claim" OnClick="btnClaim_Click1" />

              
                 <asp:Button type="button" class="btn btn-dark"  ID="btnRenewal" runat="server" Text="Renewal" OnClick="btnRenewal_Click" />
               
                
                <asp:Button type="button" class="btn btn-dark" ID="btnReport" runat="server" Text="Report" OnClick="btnReport_Click" />
              
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="lblWelcome" runat="server" Text="WELCOME"></asp:Label>&nbsp;&nbsp;
                 <asp:Label ID="lblWelcomeUser" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button type="button" class="btn btn-dark" ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            </a> 
            <button class="navbar-toggler navbar-toggler-right border-0" type="button" data-toggle="collapse" data-target="#navbar10">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbar10">
                 <ul class="navbar-nav ml-auto">
                </ul>
            </div>
        </div>
    </nav>


        <div class="w3-row-padding w3-padding-64 w3-theme-l1" id="work">

<div class="w3-quarter">
<h2>Our Work</h2>
<p>We regard insurance as more than just a subject matter of solicitation. We see it as a commitment to building engaged relationships through solutions that help our customers live confidently. We’d want to represent genuine Customer Care rather than mere Customer Service!
Whether you’re an optimist, a pessimist or a realist, there is no denying that life favours the prepared. With tailored solutions that offer continuity and assurance, we help you be, do and have anything you aspire to, without undue stress or worry!
We aim to provide simple and effective products that give you better value for money and provide flexible coverage suited to your needs. Our mission is to enrich your life by letting your explore and experience its fullest potential. While the potential for risk and loss always exists, our products help you quickly regain balance and continuity in unfortunate situations.</p>
</div>

<div class="w3-quarter">
    <h1><span class="badge badge-secondary">Tax-Saving Deduction</span></h1>
<div class="w3-card w3-white">
  <img src="tax.png" alt="" style="width:100%">
  <div class="w3-container">

  
  <p>The amount you pay towards health insurance premium claimed as a tax-saving deduction under Section 80D. You can claim ₹25,000 annually for a health insurance policy for yourself. If you also pay premium for your parents, you can claim up to ₹30,000 for the same as well.Our policy provides you peace of mind.</p>
 
  </div>
  </div>
</div>

<div class="w3-quarter">
     <h1><span class="badge badge-secondary">Benefits we Provide</span></h1>
<div class="w3-card w3-white">
  <img src="ben.jpg" alt="" style="width:100%">
  <div class="w3-container">
  
  
  <p> Cashless Treatment</p>
  <p>Pre and post hospitalization cost coverage</p>
  <p>Transportation Charges</p>
  <p>Room Rent</p>
  <p>Medical Checkup</p>
  </div>
  </div>
</div>

<div class="w3-quarter">
     <h1><span class="badge badge-secondary">Government schemes</span></h1>
<div class="w3-card w3-white">
  <img src="in.png" alt="Mountains" style="width:100%">
  <div class="w3-container">
 
 
  <p>Rashtriya Swasthya Bima Yojana (RSBY)</p>
  <p>Pradhan Mantri Suraksha Bima Yojana</p>
  <p>Central Government Health Scheme (CGHS)</p>
  <p>Aam Aadmi Bima Yojana (AABY)</p>

  </div>
  </div>
</div>

</div>
        <br />
        <br />
       



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
