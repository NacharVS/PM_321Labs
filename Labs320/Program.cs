// See https://aka.ms/new-console-template for more information
using Labs320;
using Labs320.IntefacesLab;

var t = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("#");
        Thread.Sleep(500);
    }
});

for (int i = 0; i < 5; i++)
{
    Console.Write("*");
    Thread.Sleep(500);
}
Task.WaitAll(t);




static void Sum(int a, int b)
{
    Console.WriteLine(a + b);
}