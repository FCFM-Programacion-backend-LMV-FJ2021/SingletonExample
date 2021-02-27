using System;

namespace SingletoExampleDW_LMV
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalObject no = new NormalObject();
            var myX = no.x;
            var myY = no.y;

            NormalObject no1 = new NormalObject();

            if (no == no1)
            {
                Console.WriteLine("no y no1 son la misma instancia");
            }
            else
                Console.WriteLine("no y no1 son diferentes");

            var so = SingletonObject.GetInstance();

            var so1 = SingletonObject.GetInstance();

            if (so == so1)
            {
                Console.WriteLine("so y so1 son la misma instancia");
            }
            else
                Console.WriteLine("so y so1 son diferentes");

        }
    }
}
