/* Напишите программу,Ю которая принимает на вход число и выдает сумму
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int len = NumberLen(number);
SumNumbers(number, len);

// Метод ввода
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Метод подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}


// Метод вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
