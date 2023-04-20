Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse (userInput);

 int i = 1;
while (i <= N)
{
    Console.WriteLine ($"{N} -> {Math.Pow(i, 3)}");
     i++;
}
