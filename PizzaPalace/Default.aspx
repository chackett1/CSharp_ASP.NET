<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaPalace._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">
            <div class="box">
                <div class="col-lg-12 text-center">
                    <div id="carousel-example-generic" class="carousel slide">

                        <ol class="carousel-indicators hidden-xs">
                            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                        </ol>


                        <div class="carousel-inner">
                            <div class="item active">
                                <img class="img-responsive img-full" src="img/PexelsPizza.jpg" alt="">
                            </div>
                            <div class="item">
                                <img class="img-responsive img-full" src="img/pixabayHamPizzaM.jpg" alt="">
                            </div>
                            <div class="item">
                                <img class="img-responsive img-full" src="img/PixabaySliceM.jpg" alt="">
                            </div>
                        </div>


                        <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                            <span class="icon-prev"></span>
                        </a>
                        <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                            <span class="icon-next"></span>
                        </a>
                    </div>
                    <h2 class="brand-before">
                        <small>Welcome to</small>
                    </h2>
                    <h1 class="brand-name">Pizza Palace</h1>
                    <hr class="tagline-divider">
                    <h2>
                        <small>Developed By<br>
                            <strong>Christopher Hackett</strong>
                        </small>
                    </h2>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="box">
                <div class="col-lg-12">
                    <hr>
                    <h2 class="intro-text text-center">About
                        <strong>Pizza Palace</strong>
                    </h2>
                    <hr>
                    <img class="img-responsive img-border img-left" src="img/PixabayPalaceS.jpg" alt="">
                    <hr class="visible-xs">
                    <p>Pizza Palace is a fictional store used to demonstrate my knowledge of C#, ASP.NET, and the Bootstrap framework. The back end code was reused from an ASP.NET tutorial that I completed from https://docs.microsoft.com/en-us/aspnet/overview.  This ASP.NET Web Forms application was coded in Visual Studio 2015 and contains a Master Page, LocalDB, and the Model-View-Controller (MVC) architecture.</p>
                    </div>
            </div>
        </div>
    </div>

</asp:Content>
