Console.Write("Введите целое число");
string userInput = Console.ReadLine() ?? "";

int userNum = int.Parse(userInput);
if (userNum %2 == 0)
{
    Console.WriteLine($"{userNum} -> да");
}
else
{
    Console.WriteLine($"{userNum} -> нет");
}