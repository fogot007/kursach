using MySql.Data.MySqlClient;

namespace kursach
{
    public class MySql
    {
        protected MySqlCommand Command;
        protected MySqlDataAdapter Adapter;

        protected MySqlConnection Connection { get; }

        protected MySql()
        {
            Connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;");
        }
    }
}
