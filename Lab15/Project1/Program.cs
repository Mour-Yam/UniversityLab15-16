using System;

namespace Project1
{
    class Program
    {
/*
1.	Напишите простой контейнерный класс для небольшой фирмы, в которой работает администратор, служащий и рабочий – производные объекты от общего базового класса. 
2.	Преобразуйте этот класс в класс с динамическим выделением памяти. 
3.	Напишите дружественную функцию для обработки объекта типа фирма.
4.	Напишите операторы для вставки и извлечения в поток объектов  класса фирма.
5.	Напишите главную программу, выполняющую создание и обработку  объекта типа фирма. 
*/

        abstract class Human
        {
            protected string? name;
            public string? Name { get { return name; } set { name = value; } }
            protected string? surname;
            public string? Surname { get { return surname; } set { surname = value; } }
            protected int age;
            public int Age { get { return age; } set { age = value; } }

            public Human() { }
            public Human(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }
        }
        class Administrator : Human
        {

        }
        class Clerk : Human
        {

        }
        class Worker : Human
        {

        }

        static void Main(string[] args)
        {


        }
    }
}