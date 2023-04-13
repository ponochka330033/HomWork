int i = 1;
bool not = true;

Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ??"";
int Num = int.Parse(userInput);

Console.WriteLine("Четные числа от 1 до " + Num);
while (i <= Num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ",");
        not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine("Нет четных чисел!");
}