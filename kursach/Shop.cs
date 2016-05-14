namespace kursach
{
    internal class Shop
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _city;
        private readonly string _adress;
        private readonly int _rating;

        public Shop(string name, string type, string city, string adress, int rating)
        {
            _name = name;
            _type = type;
            _city = city;
            _adress = adress;
            _rating = rating;
        }

        public void InsertIntoDatabase()
        {
            string query =
                "INSERT INTO shops(shop_name, shop_type, shop_city, shop_adress, shop_rating) VALUES(@name,@type,@city,@adress,@rating)";


            var conn = new MySqlConnect();
            conn.Query(query, _name, _type, _city, _adress, _rating);
        }

        public string Name => _name;

        public string Type => _type;

        public string City => _city;

        public string Adress => _adress;

        public int Rating => _rating;
    }
}