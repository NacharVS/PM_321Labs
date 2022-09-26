// See https://aka.ms/new-console-template for more information
using Labs320;
using Labs320.IntefacesLab;

User user = new User("Billy","billy@mail.ru", 44 );
user.AddItem(new Item("Pen", 5));
user.AddItem(new Item("Eraiser", 1));
user.AddItem(new Item("Pencil", 3));

MongoExamples.ReplaceByName("Billy", user);

static void Info(int value)
{
    Console.WriteLine($"Health Value - {value}");
}

static void InfoExtended(int value, int val2)
{
    Console.WriteLine($"Health Value - {value} Max - {val2}");
}

static void Rage()
{
    Console.WriteLine("Rage is activated!");
}

static void Adrenaline()
{
    Console.WriteLine("Opa opa adrenaline!111");
}

