Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int Number = int.Parse (userInput);
int Num = 0;

if (Number >= 100)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    Num = Number % 10;
    Console.WriteLine($"{Number} -> {Num}");
}
else 
{
    Console.WriteLine ("Третьей цифры нет");
}
