// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1 вариант:

// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // вводим число и оно попадает в переменную number
// string numberText = number.ToString(); // метод ToString => число переводит в строку и передает в переменную numberText
// char[] namberMassiv =  numberText.ToCharArray(); // char[] => создаем массив char,что бы по одному символу считать нашу строку
// // с помощью метода ToCharArray() => конвертируем текст из строкового формата в символьный массив.

// Array.Reverse(namberMassiv); // метод Array.Reverse => переворачиват массив в обратном порядке.

// string numberStrok = new string(namberMassiv); // обратно в строковый формат для сравнения

// if (numberText == numberStrok)
// {
//     Console.Write("Да, это палиндром!");
// }
// else if (numberText != numberStrok)
// {
//     Console.Write("Не палиндром!");
// }

// 2 вариант 

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10000; 
int b = ((number / 1000) % 10);
int c = ((number / 100) % 10);
int d = ((number / 10) % 10);
int e = number % 10;

if (a == e && b == d && c == c)
{
    Console.Write("Да, это палиндром!");
}
else
{
    Console.Write("Не палиндром!");
}
