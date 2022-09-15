// See https://aka.ms/new-console-template for more information
using Labs320;
using Labs320.IntefacesLab;

IWeapon weapon = new Shotgun();
weapon.ShowInfo();

weapon.SingleShoot();
weapon = new Machinegun();
weapon.SingleShoot();
IAutomaticWeapon weapon2 = new Machinegun();
weapon2.MultiShoot();



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

