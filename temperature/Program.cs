Console.WriteLine("Temperature converter");
Console.WriteLine("Press F to convert from fahrenheit or C to convert from celsius");
string ForC = Console.ReadLine();

int f = 0, c = 0;
bool validInput = true;

if (ForC == "F" || ForC == "f") 
{
    Console.WriteLine("\nEnter fahrenheit degrees");
    f = Convert.ToInt32(Console.ReadLine());
    c = ((f - 32) * 5) / 9;
}
else if (ForC == "C" || ForC == "c")
{
    Console.WriteLine("\nEnter celsius degrees");
    c = Convert.ToInt32(Console.ReadLine());
    f = ((c * 9) / 5) + 32;
}
else
{
    Console.WriteLine("ERROR!");
    validInput = false;
}

if (validInput)
{
    Console.WriteLine("\nResults:");
    Console.WriteLine(f + " degrees fahrenheit");
    Console.WriteLine(c + " degrees celsius");
}