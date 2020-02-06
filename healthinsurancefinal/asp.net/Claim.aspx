<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Claim.aspx.cs" Inherits="Claim" %>

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
    <style>
        .card-img-claim {
    width: 100%;
    height: 22vw;
    object-fit: cover;
}
    </style>

</head>
<body>
    <form id="form1" runat="server">
   
 <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
        <div class="container">
            <i class="fa fa-handshake-o" style="font-size:36px;color:white"></i><a class="navbar-brand" href="#">
                &nbsp;<b>HEALTH INSURANCE</b>
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


        <div style="margin-left:450px">

        <h1><span class="badge badge-secondary">HEALTH INSURANCE CLAIM PROCESS </span></h1>
        <h3 style="margin-left:50px">Register your health insurance claim </h3>
        </div>

        <div class="row">
  <div class="col-sm-3">
  <div class="card">
    <img src="pg.png" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">Dial our Toll-free number</h5>
        <p class="card-text">1800-111-1212</p>
   
    </div>
  </div>
      </div>
             <div class="col-sm-3">
  <div class="card">
    <img src="e.jpg" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">Email us on</h5>
      <p class="card-text">xyz@gmail.com</p>
      
    </div>
  
</div>
      </div>

            <div class="col-sm-3">
  <div class="card">
    <img src="c.png" class="card-img-claim" alt="..." style="resize:vertical">
    <div class="card-body">
      <h5 class="card-title">Reimburstment</h5>
        <asp:Button type="button" class="btn btn-success" ID="btnclaim2" runat="server" Text="Claim" OnClick="btnclaim2_Click" />      
    </div>
  
</div>
      </div>

            </div>
        <div style="margin-left:450px">

        <h2><span class="badge badge-secondary">Process requirements</span></h2>
            </div>
        <b>Please have the following information ready when you call the Call Center:</b>
        <ul>
      <li>Your Contact numbers</li>
      <li>Policy Number</li>
      <li>Name of Injured person (s.no. in the schedule of the policy)</li>
      <li>Designation and grade of the person and since when he is covered under the policy</li>
      <li>Date & Time of Loss</li>
            <li>Location of accident</li>
            <li>Nature of accident</li>
            <li>Nature of injury</li>
            <li>Place & contact details where insured person may be visited (home/hospital)</li>          
    </ul>

        <h3><span class="badge badge-secondary">The following is a general check list of documents required for processing your claim:</span></h3>
        <br />
        <b>Hospital Cash / Medical Benefit Claims</b>
        <ul>
      <li>Claim Form</li>
      <li>Attending Doctor's report</li>
      <li>Hospital discharge card/ proof of hospitalization with details of treatment.</li>
      <li>Bills with prescriptions</li>
      <li>Pathological Reports/ X-rays, X-ray Reports.</li>
                  
    </ul>

         <b>Weekly Benefit Claims</b>
        <ul>
      <li>Claim Form</li>
      <li>Attending Doctor's Report</li>
      <li>Disability Certificate from the Doctor, if any</li>
      <li>Investigation /Lab reports (x-rays &reports etc.)</li>
      <li>Original Admission/discharge card, if hospitalized</li>
            <li>Employers Leave Certificate, with grade/designation</li>
            <li>Details of salary-Latest Salary Certificate.</li>
                  
    </ul>


         <b>Death Claims</b>
        <ul>
      <li>Claim Form</li>
      <li>Attending Doctor's report</li>
      <li>Original Death Certificate</li>
      <li>Original / Attested Post Mortem / Coroner's report</li>
      <li>Attested copy of FIR / Panchanama</li>
            <li>Police Inquest report, where applicable</li>           
    </ul>


        <p>We may request for additional documents, if required, depending on the case</p>

        <b>click below to see claim process flowchart</b>
        
        <h3><span class="badge badge-secondary"><a href="https://www.reliancegeneral.co.in/Downloads/Product_1_Cashless_Reimbursement_Process%20(2).pdf" >Check Me!</a></span></h3>

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
