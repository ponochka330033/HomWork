﻿Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine () ?? "";
int a = int.Parse (userInput);

if (a > 1 && a < 5)
{
    Console.WriteLine ("не является выходным");
}

else if (a == 6 || a == 7)
{
    Console.WriteLine ("Является выходным");
}
else
{
    Console.WriteLine ("Нет такого дня недели");
}