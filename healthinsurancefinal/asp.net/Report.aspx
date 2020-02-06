<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

   
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


   <div class="container">
       
       
       <div class="form-group col-md-8" style="margin-left:50px" >
           <div class="card mr-auto" runat="server" style="margin-top:90px;margin-left:300px;">
              
             <h1 class="card-title" align="center"><span class="badge badge-dark">REPORT</span></h1>
       
  
    

  &nbsp;&nbsp;&nbsp;&nbsp;    Enter PolicyID: <br />
      <asp:TextBox type="text" class="form-control col-md-10 ml-4" ID="tbreportPolicyID" runat="server" TextMode="SingleLine"></asp:TextBox>  <br />
     <br />
        &nbsp;&nbsp;&nbsp;&nbsp;        Select Problems
       
       
       <asp:DropDownList type="text" class="form-control col-md-10 ml-4"  ID="ddquestion" runat="server">
           <asp:ListItem Value="1">My Renewal isn&#39;t updated</asp:ListItem>
           <asp:ListItem Value="2">Claim not yet Apporoved</asp:ListItem>
           <asp:ListItem Value="3">Error uploading files</asp:ListItem>
           <asp:ListItem Value="4">I want to change my Details </asp:ListItem>
           <asp:ListItem Value="5">Unable to contact customer service</asp:ListItem>
       </asp:DropDownList>
            
      <br />
 &nbsp;&nbsp;&nbsp;&nbsp;        Comment:
       <asp:TextBox type="text" class="form-control  col-md-10 ml-4" ID="tbComment" runat="server" Height="200px" Width="181px"></asp:TextBox>
      &nbsp;&nbsp;
             <asp:Button type="button" class="btn btn-success col-md-10 ml-4" ID="btnReport" runat="server" Text="Report" OnClick="btnReport_Click" />
          <br />       
</div>          
  
</div>
</div>
            


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
