Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine() ?? "";
int Num = int.Parse(userInput);
int a = Num/10;
int b = a % 10;
Console.WriteLine ($"Вторая цифра числа {Num} -> {b}");

