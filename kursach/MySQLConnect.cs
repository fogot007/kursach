using System;
using MySql.Data.MySqlClient;

namespace kursach
{
    class MySqlConnect
    {
        private readonly MySqlConnection _connection;
        private MySqlCommand _command;

        public MySqlConnect(string host, string user, string password, string database)
        {
            var myConnectionString = "server=" + host + ";uid=" + user + ";pwd=" + password + ";database=" + database +
                                     ";";
            _connection = new MySqlConnection(myConnectionString);
        }

        public MySqlConnect()
        {
            var myConnectionString = "server=localhost;uid=root;pwd=1111;database=Shops;";
            _connection = new MySqlConnection(myConnectionString);
        }

        public void Open()
        {
            _connection.Open();
        }

        public void Close()
        {
            _connection.Close();
        }

        public void Query(string query, string name, string type, string city, string adress, int rating)
        {
            try
            {
                _connection?.Open();
                _command = new MySqlCommand
                {
                    Connection = _connection,
                    CommandText = query
                };

                _command.Prepare();
                _command.Parameters.AddWithValue("@name", name);
                _command.Parameters.AddWithValue("@type", type);
                _command.Parameters.AddWithValue("@city", city);
                _command.Parameters.AddWithValue("@adress", adress);
                _command.Parameters.AddWithValue("@rating", rating);
                _command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error: {e}");
            }
            finally
            {
                _connection?.Close();
            }
        }

        public void Query(string query)
        {
            try
            {
                _connection?.Open();
                _command = new MySqlCommand
                {
                    Connection = _connection,
                    CommandText = query
                };

                _command.Prepare();
                _command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error: {e}");
            }
            finally
            {
                _connection?.Close();
            }
        }

        public void Query(string query, string login, string password)
        {
            try
            {
                _connection?.Open();
                _command = new MySqlCommand
                {
                    Connection = _connection,
                    CommandText = query
                };

                _command.Prepare();
                _command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error: {e}");
            }
            finally
            {
                _connection?.Close();
            }

        }
    }
}