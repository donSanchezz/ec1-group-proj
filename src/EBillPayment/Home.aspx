<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EBillPayment.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="container-fluid background-image">
            <div class="row d-flex">
                <div style="height: 100vh;" class="col-md-6 d-flex flex-column justify-content-center align-items-center">
                    <h1 class="font-weight-bold text-info">PAY</h1>
                    <h1 class="font-weight-bold text-info">ONLINE</h1>
                    <div class="col-md-5">
                    <p class="text-light">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s. </p>
                        </div>

                    <div class="col-md-5 d-flex justify-content-center">

                         <asp:LinkButton class="btn btn-outline-info btn-lg" Text="GET STARTED" ID="LinkButton2" runat="server" PostBackUrl="~/Register.aspx"></asp:LinkButton>
                    </div>
                </div>

                <div style="height: 100vh;" class="col-md-6 d-flex justify-content-center align-items-center">
                       <img src="imgs/online_payment.svg" alt="bank" class="img-fluid"/>
                </div>
            </div>

        </div>
 



</asp:Content>
