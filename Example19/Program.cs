Console.Write ("Введите число: ");
string palindrome = Console.ReadLine () ?? "";
int count = palindrome.Length;

if (count == 5)
{
    if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
    {
        Console.WriteLine ("Палиндром");
    }
    else
    {
        Console.WriteLine ("Не палиндром");
    }
}
else
{
    Console.WriteLine ("Ошибка ввода");
}
