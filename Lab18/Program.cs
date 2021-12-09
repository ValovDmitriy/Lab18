using System;
using System.Collections.Generic;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка правильности расстановки скобок");
            Console.WriteLine("Введите строку со скобками:");
            string stroka = Console.ReadLine();
            char[] symbs = stroka.ToCharArray();
            char krOskobka = '(';
            char krZskobka = ')';
            char kvOskobka = '[';
            char kvZskobka = ']';
            char fiOskobka = '{';
            char fiZskobka = '}';
            Stack<char> skobki = new Stack<char>();
            foreach (char symb in symbs)
            {
                if (symb == krOskobka)
                {
                    skobki.Push(kvZskobka);
                }
                if (symb == kvOskobka)
                {
                    skobki.Push(kvZskobka);
                }
                if (symb == fiOskobka)
                {
                    skobki.Push(fiZskobka);
                }
                if (symb == krZskobka)
                {
                    skobki.Pop();
                }
                if (symb == kvZskobka)
                {
                    skobki.Pop();
                }
                if (symb == fiZskobka)
                {
                    skobki.Pop();
                }

            }
            if (skobki.Count==0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }
        }
    }
}

