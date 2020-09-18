using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace Lab_rab_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабараторня работа №1:Разработка консольного приложения");
            Console.WriteLine("ФИО: Байсултанов Ахмед Аладович");
            Console.WriteLine("Группа: ИНС-Б-о-19-1; 09.03.02");
            Console.WriteLine("Дата рождения: 21.08.2002");
            Console.WriteLine("Место жительства: с.Надтеречное, ул.Гагарина б/н");
            Console.WriteLine("Любимый предмет в школе: Математика");
            Console.WriteLine("Увлечение : Спорт");

            int  rx, z, f1, Et, ch;

            rx = 2;
            z = 3;
            f1 = 4;
            Et = 5;
            Console.WriteLine($"Значение rx = {rx} ") ;
            Console.WriteLine($"Введите z = {z} ");
            Console.WriteLine($"Введите f1 = {f1} ");
            Console.WriteLine($"Введите E1 = {Et}");


            ch = rx * z + z * f1 - ((f1 + Et) / rx);

            Console.WriteLine($"Ваш результат: {ch} ") ;



            Console.ReadKey();
        }
    }
}
