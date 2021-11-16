using EBillPayment.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBillPayment.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Dashboard.aspx");
            }
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var user = new ApplicationUser() { 
                FirstName = FirstName.Text, 
                LastName = LastName.Text, 
                UserName = Username.Text, 
                PhoneNumber = ContactNum.Text, 
                Email = Email.Text,
                Address = Address.Text,
            };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                //manager.AddToRole(user.Id, "Customer");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);

                try
                {  //Create a sql connection
                    SqlConnection con = new SqlConnection(Global.strcon);
                    //Check if the connection is open, if not, then open it.
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand insertCmd = new SqlCommand("INSERT INTO Accounts(Id, Savings, Chequing, Sagicor, Flow) values(@Id, @Savings, @Chequing, @Sagicor, @Flow)", con);
                    insertCmd.Parameters.AddWithValue("@Id", user.Id);
                    insertCmd.Parameters.AddWithValue("@Savings", 0);
                    insertCmd.Parameters.AddWithValue("@Chequing", 0);
                    insertCmd.Parameters.AddWithValue("@Sagicor", 0);
                    insertCmd.Parameters.AddWithValue("@Flow", 0);
                    insertCmd.ExecuteNonQuery();


                    SqlCommand insertCmdSagicor = new SqlCommand("INSERT INTO Sagicor(Id, Amount) values(@Id, @Amount)", con);
                    insertCmdSagicor.Parameters.AddWithValue("@Id", user.Id);
                    insertCmdSagicor.Parameters.AddWithValue("@Amount", 0);
                    insertCmdSagicor.ExecuteNonQuery();

                    SqlCommand insertCmdFlow = new SqlCommand("INSERT INTO Flow(Id, Amount) values(@Id, @Amount)", con);
                    insertCmdFlow.Parameters.AddWithValue("@Id", user.Id);
                    insertCmdFlow.Parameters.AddWithValue("@Amount", 0);
                    insertCmdFlow.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Response.Redirect("Home.aspx");
                //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                //ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}