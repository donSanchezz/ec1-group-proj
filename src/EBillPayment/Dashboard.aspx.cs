using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EBillPayment.Model;
using EBillPayment.ServiceReference1;
using Microsoft.AspNet.Identity;

namespace EBillPayment
{
    public partial class Dashboard : System.Web.UI.Page
    {
        WebService1SoapClient obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

          obj = new WebService1SoapClient();
            var Id = Context.User.Identity.GetUserId();
            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Select Savings, Chequing, Flow, Sagicor from Accounts where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id );
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SavingsAcc.Text = reader.GetDouble(0).ToString();
                        ChequingAcc.Text = reader.GetDouble(1).ToString();
                        var flow = reader.GetBoolean(2);
                        var sagicor = reader.GetBoolean(3);


                        if (flow)
                        {
                            Flow.Text = obj.GetFlowBalance(Id).ToString();
                        }

                        if (sagicor)
                        {
                            Sagicor.Text = obj.GetSagicorBalance(Id).ToString();
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            SqlDataSource1.SelectParameters["Id"].DefaultValue = Context.User.Identity.GetUserId();

            if (Global.payment == 1)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Success", "swal('Payment Successful!', 'Your payment has been made', 'success');", true);
                Global.payment = 0;
            }
        }

        protected void Link_Clicked(object sender, EventArgs e)
        {
            var Id = Context.User.Identity.GetUserId();
            var accType = DropDownList1.SelectedValue;

            var value = obj.LinkAccount(Id, accType);

            if (accType == "Flow" && value > 0)
            {
                Flow.Text = value.ToString();
                this.ClientScript.RegisterStartupScript(this.GetType(), "Success", "swal('Account Linked!', 'Your Flow account has been linked', 'success');", true);
            }
            else if (accType == "Sagicor" && value > 0)
            {
                Sagicor.Text = value.ToString();
                this.ClientScript.RegisterStartupScript(this.GetType(), "Success", "swal('Account Linked!', 'Your Sagicor account has been linked', 'success');", true);
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'There was an error linking your account', 'error');", true);
            }

        }

        protected void PayBill_Clicked(object sender, EventArgs e)
        {
            var From = DropDownList3.SelectedValue;
            var To = DropDownList4.SelectedValue;
            var amount = float.Parse(Amount.Text);
            var savings = float.Parse(SavingsAcc.Text);
            var chequing = float.Parse(ChequingAcc.Text);
            var flow = float.Parse(Flow.Text);
            var sagicor = float.Parse(Sagicor.Text);
            var Id = Context.User.Identity.GetUserId();




            if (AccNum.Text == Id)
            {
               if(From == "Savings" && To == "Flow")
                {
                    if(amount <= savings)
                    {
                        obj.MakePaymentFlow(Id, savings, amount, From, flow);
                        Global.payment = 1;
                        Response.Redirect(Request.RawUrl);
                        
                    }
                    else
                    {
                        this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'Insufficient funds', 'error');", true);

                    }

                }

                if (From == "Savings" && To == "Sagicor")
                {
                    if (amount <= savings)
                    {
                        obj.MakePaymentFlow(Id, savings, amount, From, sagicor);
                        Global.payment = 1;
                        Response.Redirect(Request.RawUrl);
                        
                    }
                    else
                    {
                        this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'Insufficient funds', 'error');", true);

                    }
                }


                if (From == "Chequing" && To == "Flow")
                {
                    if (amount <= chequing)
                    {
                        obj.MakePaymentSagicor(Id, chequing, amount, From, flow);
                        Global.payment = 1;
                        Response.Redirect(Request.RawUrl);
                        
                    }
                    else
                    {
                        this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'Insufficient funds', 'error');", true);

                    }
                }

                if (From == "Chequing" && To == "Sagicor")
                {

                    if (amount <= chequing)
                    {
                        obj.MakePaymentSagicor(Id, chequing, amount, From, sagicor);
                        Global.payment = 1;
                        Response.Redirect(Request.RawUrl);
                        
                    }
                    else
                    {
                        this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'Insufficient funds', 'error');", true);

                    }
                }

            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "swal('Oops!', 'Account Number is not valid, please try again', 'error');", true);
            }
            
        }
    }
}