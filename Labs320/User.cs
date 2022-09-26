using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labs320
{
    internal class User
    {
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
            Items = new List<Item>();
        }

        public User(string name, string email, int age, int driverCard)
        {
            Name = name;
            Email = email;
            Age = age;
            DriverCard = driverCard;
            Items = new List<Item>();
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            Items = new List<Item>();
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public string Email { get; set; }
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }

        [BsonIgnoreIfNull]
        List<Item> Items { get; set; }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
