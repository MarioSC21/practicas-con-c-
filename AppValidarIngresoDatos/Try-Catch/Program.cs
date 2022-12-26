// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n1, n2;
try
{
    Console.WriteLine("Ingres el numero");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingres el numero2");
    n2 = int.Parse(Console.ReadLine());

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}