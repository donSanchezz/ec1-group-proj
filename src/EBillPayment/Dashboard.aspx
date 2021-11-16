<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="EBillPayment.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
        $(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
    });
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-evenly g-2">

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <div class="d-flex flex-row align-content-center ms-2">
                        <i class="fab fa-product-hunt fa-2x"></i>
                        <h5 class="ms-2">Savings</h5>
                    </div>

                    <div class="card-body">
                        <div class="d-flex flex-row align-items-center">
                            <asp:Label ID="SavingsAcc" runat="server" Text="0" Font-Size="X-Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <div class="d-flex flex-row align-content-center ms-2">
                        <i class="fas fa-copyright fa-2x"></i>
                        <h5 class="ms-2">Chequing</h5>
                    </div>

                    <div class="card-body">
                        <div class="d-flex flex-row align-items-center">
                         <asp:Label ID="ChequingAcc" runat="server" Text="0" Font-Size="X-Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <div class="d-flex flex-row align-content-center ms-2">
                        <i class="fas fa-wallet fa-2x"></i>
                        <h5 class="ms-2">Flow</h5>
                    </div>

                    <div class="card-body">
                        <div class="d-flex flex-row align-items-center">
                           <%-- <h4>$</h4>--%>
                            <asp:Label ID="Flow" runat="server" Text="NOT LINKED" Font-Size="X-Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <div class="d-flex flex-row align-content-center ms-2">
                        <i class="fab fa-stripe-s fa-2x"></i>
                        <h5 class="ms-2">Sagicor</h5>
                    </div>

                    <div class="card-body">
                        <div class="d-flex flex-row align-items-center">
                            <%--<h4>$</h4>--%>
                            <asp:Label ID="Sagicor" runat="server" Text="NOT LINKED" Font-Size="X-Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

        </div>


        <div class="row mt-3 d-flex g-5">
        
            <div class="col-md-6">
            
                <div class="d-flex justify-content-center align-content-center">
            <img src="imgs/link_account.svg" style="height: 200px; width: 300px;" alt="link" class="img-fluid"/>
                    </div>
  

                <div class="row">
                    <div class="col-md-6">
                        <label for="" class="form-label">First Name</label>
                        <div class="form-group">
                            <asp:TextBox class="form-control" placeholder="John" ID="FirstName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ValidationGroup="Link" ControlToValidate="FirstName"
                                class="text-danger" ErrorMessage="The First Name field is required." />
                        </div>

                    </div>

                    <div class="col-md-6">
                        <label for="" class="form-label">Last Name</label>
                        <div class="form-group">
                            <asp:TextBox class="form-control" placeholder="Doe" ID="LastName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ValidationGroup="Link" ControlToValidate="LastName"
                                class="text-danger" ErrorMessage="The Last Name field is required." />
                        </div>
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-6">
                        <label for="" class="form-label">Email</label>
                        <div class="form-group">
                            <asp:TextBox class="form-control" placeholder="johndoe@gmail.com" TextMode="Email" ID="Email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ValidationGroup="Link" ControlToValidate="Email"
                                class="text-danger" ErrorMessage="The Email field is required." />
                        </div>
                    </div>
                    <div class="col-md-6">
                        <label for="" class="form-label">Account Type</label>
                        <div class="form-group">
                            <asp:DropDownList class="form-control" placeholder="" ID="DropDownList1" runat="server" AutoPostBack="true">
                                <asp:ListItem Text="Sagicor" Value="Sagicor"> </asp:ListItem>
                                <asp:ListItem Text="Flow" Value="Flow"> </asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>

                    <div class="d-grid gap-2 form-group">
                        <a href="usersignup.aspx">
                            <asp:Button runat="server" Text="Link Account" ValidationGroup="Link" class="form-control btn btn-primary btn-sm" OnClick="Link_Clicked" />
                        </a>
                    </div>
                </div>
            </div>


            <div class="col-md-6">

                  <div class="d-flex justify-content-center align-content-center">
            <img src="imgs/pay.svg" style="height: 200px; width: 300px;" alt="link" class="img-fluid"/>
                    </div>


                <div class="row">
                    <div class="col-md-6">
                        <label for="" class="form-label">Account Number</label>
                        <div class="form-group">
                            <asp:TextBox class="form-control" placeholder="8a160d77-2efe-4fba-b31c-3f29bd4bbdaf" ID="AccNum" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ValidationGroup="Bill" ControlToValidate="AccNum"
                                class="text-danger" ErrorMessage="The Account Number field is required." />
                        </div>

                    </div>

                    <div class="col-md-6">
                        <label for="" class="form-label">Amount</label>
                        <div class="form-group">
                            <asp:TextBox class="form-control" placeholder="0" ID="Amount" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ValidationGroup="Bill" ControlToValidate="Amount"
                                class="text-danger" ErrorMessage="The Amount field is required." />
                        </div>
                    </div>

                </div>



                <div class="row">

                    <div class="col-md-6">
                        <label for="" class="form-label">From</label>
                        <div class="form-group">
                            <asp:DropDownList class="form-control" placeholder="" ID="DropDownList3" runat="server" AutoPostBack="true">
                                <asp:ListItem Text="Savings" Value="Savings"> </asp:ListItem>
                                <asp:ListItem Text="Chequing" Value="Chequing"> </asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>

                    <div class="col-md-6">
                        <label for="" class="form-label">To</label>
                        <div class="form-group">
                            <asp:DropDownList class="form-control" placeholder="" ID="DropDownList4" runat="server" AutoPostBack="true">
                                <asp:ListItem Text="Sagicor" Value="Sagicor"> </asp:ListItem>
                                <asp:ListItem Text="Flow" Value="Flow"> </asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>


                </div>
                <div class="row mt-4">
                    <div class="d-grid gap-2 form-group">
                        <a href="usersignup.aspx">
                            <asp:Button runat="server" Text="Pay Bill" ValidationGroup="Bill" class="form-control btn btn-primary btn-sm" onclick="PayBill_Clicked" />
                        </a>
                    </div>
                </div>



            </div>

            <div class="row mt-5">
                <div class="col">
                    <h3>Transactions</h3>
                </div>

            </div>

            <div class="row">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT [From], [To], [Amount], [Date &amp; Time] AS 'Date &amp; Time' FROM [Transactions] WHERE Id = @Id">
                    <SelectParameters>
                        <asp:Parameter Name="Id" />
                    </SelectParameters>
                </asp:SqlDataSource>

                <asp:GridView ID="GridView1" runat="server" class="table table-striped table-bordered" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="From" HeaderText="From" SortExpression="From" />
                        <asp:BoundField DataField="To" HeaderText="To" SortExpression="To" />
                        <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                        <asp:BoundField DataField="Date &amp; Time" HeaderText="Date &amp; Time" SortExpression="Date &amp; Time" />
                    </Columns>
                </asp:GridView>

            </div>

        </div>
        </div>
</asp:Content>
