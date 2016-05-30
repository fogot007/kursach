namespace kursach
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string City { get; set; }

        public string Adress { get; set; }

        public int Rating { get; set; }

        public Shop(int id, string name, string type, string city, string adress, int rating)
        {
            Id = id;
            Name = name;
            Type = type;
            City = city;
            Adress = adress;
            Rating = rating;
        }

        public Shop()
        {
            Id = 0;
            Name = "";
            Type = "";
            City = "";
            Adress = "";
            Rating = 0;
        }

        public Shop(string name, string type, string city, string adress, int rating)
        {
            Id = 0;
            Name = name;
            Type = type;
            City = city;
            Adress = adress;
            Rating = rating;
        }
    }
}