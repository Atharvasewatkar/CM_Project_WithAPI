using AllOperationsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllOperationsLibrary.Operation
{
    public class AddCustomer
    {

        public static string ConnectionString = @"Data Source=DESKTOP-J5B203A;Initial Catalog=Cable_Management;Integrated Security=True";
       

        public static string AddCustomeM(CustomerEntity ce)

        { 

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[USP_API_ADD_NEW_CUSTOMER] '{ce.NAME}','{ce.ADDRESS}','{ce.CONTACT}','{ce.DATE_OF_BIRTH}','{ce.CITYID}','{ce.PACKAGEID}','{ce.GROUPID}','{ce.USER_ID}','{ce.PASSWORD}'", connection);

                connection.Open();
                int  reader = command.ExecuteNonQuery();
               
                
                connection.Close();

            }
            return "Customer added";
        }
    }
}
