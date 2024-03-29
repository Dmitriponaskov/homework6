﻿/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) // int выводиm
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}


void GetPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*(b2-b1)/(k1-k2)+b1;
    if (k1==k2)
    {
        Console.WriteLine($"Прямые y = {k1} * x + {b1}, y = {k2} * x + {b2} параллельны. Точки пересечения нет.");
    }
    Console.WriteLine($"Координаты точки пересечения прямых y = {k1} * x + {b1}, y = {k2} * x + {b2}: [{x};{y}].");
}

double k1 = GetNumber("Введите значение k1: ");
double k2 = GetNumber("Введите значение k2: ");
double b1 = GetNumber("Введите значение b1: ");
double b2 = GetNumber("Введите значение b2: ");
GetPoint(k1, k2, b1, b2);