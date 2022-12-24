// See https://aka.ms/new-console-template for more information
Console.WriteLine("First item");
var p = Console.ReadLine();
Console.WriteLine("Price");
var x = Console.ReadLine();
var xp = int.Parse(x);
Console.WriteLine("Second item");
var y = Console.ReadLine();
Console.WriteLine("Price");
var yp = Console.ReadLine();
var ypp = int.Parse(yp);

Console.WriteLine("In your cart there are");
Console.WriteLine("First Item:");
Console.WriteLine(p);
Console.WriteLine("$" + xp);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Second Item:");
Console.WriteLine(y);
Console.WriteLine("$" + ypp);
Console.WriteLine("");
Console.WriteLine("");
int v = ypp + xp;
Console.WriteLine("Total is $" + v);
Console.WriteLine("Do you wanna check out? 1:Yes 2:No");
var answer = Console.ReadLine();
var answerp = int.Parse(answer);
if(answerp == 1)
{
    Console.WriteLine("Sucess! Paid $" + v + "for " + p + "and " + y);
}
