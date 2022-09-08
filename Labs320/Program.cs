// See https://aka.ms/new-console-template for more information
using Labs320;

TestClass unit = new TestClass(100);
unit.HealthChangedEvent += InfoExtended;



unit.TakeDamage(20);
unit.TakeDamage(10);
unit.TakeDamage(15);
unit.TakeDamage(30);


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

