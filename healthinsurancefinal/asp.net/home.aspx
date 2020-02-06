<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body >
    <form id="form1" runat="server"  >
    

    <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
        <div class="container">
           <img src="hplus.png" class="d-block w-30" alt="..." width="20%" height="80px"> <a class="navbar-brand" href="#">
                &nbsp;<b>HEALTH INSURANCE</b>
            </a> <button class="navbar-toggler navbar-toggler-right border-0" type="button" data-toggle="collapse" data-target="#navbar10">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbar10">
                <ul class="navbar-nav ml-auto">
                    <asp:Button type="button" class="btn btn-dark" ID="btnBuyPolicy" runat="server" Text="Register" OnClick="btnBuyPolicy_Click" />    
                    <asp:Button type="button" class="btn btn-dark" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />  

                              
                </ul>
            </div>
        </div>
    </nav>


     



        <!--CAROUSEL-->
        <div id="carouselExampleInterval" class="carousel slide" data-ride="carousel" style="top:20px;">
        <div class="carousel-inner">
            <div class="carousel-item active" data-interval="1000" style="height:50%;">
                <img src="thhhh.jpg" class="d-block w-100" alt="..." width="100%" height="650px">
            </div>
            <div class="carousel-item" data-interval="1000">
                <img src="thh.jpg" class="d-block w-100" alt="..." width="100%" height="650px">
            </div>
            <div class="carousel-item">
                <img src="thhh.jpg" class="d-block w-100" alt="..." width="100%" height="650px">
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleInterval" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleInterval" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

        <div  style="background-color:black">
        <!--three partitions-->
       <br />
        <br />
            </div>

<div class="w3-row-padding  w3-center w3-margin-top" >
    <div class="w3-third" >
        <div class="w3-card w3-container w3-black" style="min-height:460px">
            <h3>Carrier Selection</h3><br>
            <i class="fa fa-certificate" style="font-size:120px"></i>
       
            <p>We offer plans from numerous health insurance companies. You will not find a better premium for these plans anywhere.</p>
            <!--<p>Mobile first fluid grid</p>
            <p>Fits any screen sizes</p>
            <p>PC Tablet and Mobile</p>-->
        </div>
    </div>

    <div class="w3-third">
        <div class="w3-card w3-container  w3-black" style="min-height:460px">
            <h3>Well Established</h3><br>
            <i class="fa fa-thumbs-up" style="font-size:120px"></i>
            
            <p>We are well established. eHealth was founded in 1997 and has been publicly traded since 2006.We owe our success to the faith you have showed in us. For the 13th consecutive year, We have received iAAA rating from ICRA, indicating the highest claims paying ability and a fundamentally strong position in the industry. The first accreditation was received in 2005-06 and the company has maintained this rating since then.</p>
            <!--<p>Easy to learn</p>
            <p>No need for jQuery</p>
            <p>No JavaScript library</p>-->
        </div>
    </div>

    <div class="w3-third">
        <div class="w3-card w3-container  w3-black" style="min-height:460px">
            <h3>Agent Support</h3><br>
            <i class="fa fa-user-plus" style="font-size:120px"></i>
            <p>We provide guidance through the process. Get advice from more than 200 licensed insurance agents at no cost or obligation to enroll.</p>
            <!--<p>Bold colors and shadows</p>
            <p>Equal across platforms</p>
            <p>Equal across devices</p>-->
        </div>
    </div>
</div>
         <div  style="background-color:white">
        <!--three partitions-->
       <br />
        <br />
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
