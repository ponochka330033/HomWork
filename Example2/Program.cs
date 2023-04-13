Console.WriteLine("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int a = int.Parse (userInput1);
int b = int.Parse (userInput2);

if (a > b)
{
    Console.WriteLine ("{a} -> max");
}
else
{
    Console.WriteLine ("{b} -> max");
}
