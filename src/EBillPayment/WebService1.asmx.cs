using EBillPayment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EBillPayment
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float LinkAccount(string Id, string accType)
        {

            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (accType == "Flow")
                {
                    SqlCommand cmd = new SqlCommand("Select Amount from Flow where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Flow=@flow WHERE Id=@id", con);
                        updateCmd.Parameters.AddWithValue("@id", Id);
                        updateCmd.Parameters.AddWithValue("@flow", 1);
                        updateCmd.ExecuteNonQuery();
                        while (reader.Read())
                        {
                            return (float)reader.GetDouble(0);
                        }
                    }
                    else
                    {
                        return 0;
                    }
                    reader.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select Amount from Sagicor where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Sagicor=@sagicor WHERE Id=@id", con);
                        updateCmd.Parameters.AddWithValue("@id", Id);
                        updateCmd.Parameters.AddWithValue("@sagicor", 1);
                        updateCmd.ExecuteNonQuery();
                        while (reader.Read())
                        {
                            return (float)reader.GetDouble(0);
                        }
                    }
                    else
                    {
                        return 0;
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        [WebMethod]
        public float GetFlowBalance(string Id)
        {
            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Select Amount from Flow where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (float)reader.GetDouble(0);
                    }
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        [WebMethod]
        public float GetSagicorBalance(string Id)
        {
            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Select Amount from Sagicor where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (float)reader.GetDouble(0);
                    }
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        [WebMethod]
        public float MakePaymentFlow(string Id, float currentBal, float Amount, string From, float ToBalance)
        {
            var newBalance = currentBal - Amount;
            var newToBalance = ToBalance + Amount;
            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Flow SET Amount=@amount WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@amount", newToBalance);
                cmd.ExecuteNonQuery();

                if(From == "Savings")
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Savings=@savings WHERE Id=@Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", Id);
                    updateCmd.Parameters.AddWithValue("@savings", newBalance);
                    updateCmd.ExecuteNonQuery();
                }else
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Chequing=@chequing WHERE Id=@Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", Id);
                    updateCmd.Parameters.AddWithValue("@chequing", newBalance);
                    updateCmd.ExecuteNonQuery();
                }

                


                SqlCommand insertCmd = new SqlCommand("INSERT INTO [Transactions](Id, [From], [To], Amount, [Date & Time]) values(@Id, @From, @To, @Amount, @DateTime)", con);
                insertCmd.Parameters.AddWithValue("@Id", Id);
                insertCmd.Parameters.AddWithValue("@From", From);
                insertCmd.Parameters.AddWithValue("@To", "Flow");
                insertCmd.Parameters.AddWithValue("@Amount", Amount);
                insertCmd.Parameters.AddWithValue("@DateTime", DateTime.Now);

                insertCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        [WebMethod]
        public float MakePaymentSagicor(string Id, float currentBal, float Amount, string From, float ToBalance)
        {
            var newBalance = currentBal - Amount;
            var newToBalance = ToBalance + Amount;
            try
            {  //Create a sql connection
                SqlConnection con = new SqlConnection(Global.strcon);
                //Check if the connection is open, if not, then open it.
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Sagicor SET Amount=@amount WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@amount", newToBalance);
                cmd.ExecuteNonQuery();

                if (From == "Savings")
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Savings=@savings WHERE Id=@Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", Id);
                    updateCmd.Parameters.AddWithValue("@savings", newBalance);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Accounts SET Chequing=@chequing WHERE Id=@Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", Id);
                    updateCmd.Parameters.AddWithValue("@chequing", newBalance);
                    updateCmd.ExecuteNonQuery();
                }
                
                SqlCommand insertCmd = new SqlCommand("INSERT INTO [Transactions](Id, [From], [To], Amount, [Date & Time]) values(@Id, @From, @To, @Amount, @DateTime)", con);
                insertCmd.Parameters.AddWithValue("@Id", Id);
                insertCmd.Parameters.AddWithValue("@From", From);
                insertCmd.Parameters.AddWithValue("@To", "Sagicor");
                insertCmd.Parameters.AddWithValue("@Amount", Amount);
                insertCmd.Parameters.AddWithValue("@DateTime", DateTime.Now);

                insertCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }


    }
}
