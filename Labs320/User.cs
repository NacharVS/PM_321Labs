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
        }

        public User(string name, string email, int age, int driverCard)
        {
            Name = name;
            Email = email;
            Age = age;
            DriverCard = driverCard;
        }

        public User( string name, int age)
        {
            Name = name;
            Age = age;
        }
        [BsonId]
        ObjectId _id;
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public string Email { get; set; }
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }
    }
}
