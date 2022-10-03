using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320
{
    internal class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);

        }

        public static void FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" {item?.Name} {item?.Email} {item?.Age} {item?.DriverCard}");
            }

        }

        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();

                Console.WriteLine($" {one?.Name} {one?.Email} {one?.Age} {one?.DriverCard}");


        }

        public static void ReplaceByName(string name, User user1)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == name, user1);
        }

        public static void TestMethod()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var update = Builders<User>.Update.Set("MilitaryTicket", 0);
            collection.UpdateMany(x => x.Age >= 18 && x.Age < 35, update);
        }
    }
}
