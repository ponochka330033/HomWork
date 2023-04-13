Console.WriteLine("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
Console.WriteLine("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNum1 = int.Parse (userInput1);
int userNum2 = int.Parse (userInput2);
int userNum3 = int.Parse (userInput3);
int max = userNum1;
if (userNum2 > max)
{ 
    max = userNum2;
}
if (userNum3 > max)
{
    max = userNum3;
}
Console.WriteLine($"{userNum1} {userNum2} {userNum3} -> {max}");