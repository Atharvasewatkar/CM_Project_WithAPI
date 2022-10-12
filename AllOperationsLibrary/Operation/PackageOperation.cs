using AllOperationsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllOperationsLibrary.Operation
{
    public class PackageOperation
    {

        public static string ConnectionString = @"Data Source=DESKTOP-J5B203A;Initial Catalog=Cable_Management;Integrated Security=True";


        public static string AddPackageM(PackageEntity pkg)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand($"insert into PACKAGE(PACKAGE,PACKAGEPRICE) VALUES('{pkg.PACKAGE}','{pkg.PACKAGEPRICE}')", connection);
                connection.Open();
                int reader = command.ExecuteNonQuery();
                connection.Close();
            }
            return "package added";

        } 
    }
}
