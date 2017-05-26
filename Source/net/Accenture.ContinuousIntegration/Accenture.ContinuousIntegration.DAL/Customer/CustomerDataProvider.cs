using Accenture.ContinuousIntegration.Common;
using Accenture.ContinuousIntegration.DAL.Interfaces;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Accenture.ContinuousIntegration.DAL.Customer
{
    public class CustomerDataProvider : ICustomerDataProvider
    {

        private readonly string _connectionString;

        public CustomerDataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ICustomer GetCustomer(int id)
        {
            using (MySqlConnection mySqlConection = new MySqlConnection(_connectionString))
            {
                mySqlConection.Open();

                MySqlCommand cmd = mySqlConection.CreateCommand();
                cmd.CommandText = "CustomerSelectById";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    var gender = dataReader.GetInt32("Gender");

                    var customer = new Customer(
                        dataReader.GetInt32("Id"),
                        dataReader.GetString("UserName"),
                        dataReader.GetString("FirstName"),
                        dataReader.GetString("LastName"),
                        (Gender)gender,
                        dataReader.GetString("EmailAddress"),
                        dataReader.GetString("PhoneNumber"));

                    return customer;
                }

                mySqlConection.Close();
            }

            return null;
        }

        public List<ICustomer> GetCustomers()
        {
            var customers = new List<ICustomer>();
            using (MySqlConnection mySqlConection = new MySqlConnection(_connectionString))
            {
                mySqlConection.Open();

                MySqlCommand cmd = mySqlConection.CreateCommand();
                cmd.CommandText = "CustomerSelect";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var gender = dataReader.GetInt32("Gender");

                    var customer = new Customer(
                        dataReader.GetInt32("Id"),
                        dataReader.GetString("UserName"),
                        dataReader.GetString("FirstName"),
                        dataReader.GetString("LastName"),
                        (Gender)gender,
                        dataReader.GetString("EmailAddress"),
                        dataReader.GetString("PhoneNumber"));

                    customers.Add(customer);
                }

                mySqlConection.Close();
            }

            return customers;
        }
    }
}
