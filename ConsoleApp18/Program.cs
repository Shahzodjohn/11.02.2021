using System;
using System.Collections;

namespace ConsoleApp18
{
   
    class Program
    {
        delegate T Operation<T>(T el1, T el2);

        public static T Addelement<T>(T el1, T el2)
        {
            return (dynamic)el1 + (dynamic)el2;
        }

        public static T Minuselement<T>(T el1, T el2)
        {
            return (dynamic)el1 - (dynamic)el2;
        }
        public static T Multiplyelemnt<T>(T el1, T el2)
        {
            return (dynamic)el1 * (dynamic)el2;
        }
        public static T devideelement<T>(T el1, T el2)
        {
            return (dynamic)el1 / (dynamic)el2;
        }


        static void Main(string[] args)
        {
            int firstnum;
            Console.WriteLine("Введите первый элемент");
            firstnum = int.Parse(Console.ReadLine());
            int secondnum;
            Console.WriteLine("Введите второй элемент");
            secondnum = int.Parse(Console.ReadLine());
            int num;
            Console.WriteLine("Введите операцию: \nНамите (1) чтобы присвоить знак (+) \nНамите (2) чтобы присвоить знак (-) \nНамите (3) чтобы присвоить знак (*) \nНамите (4) чтобы присвоить знак (/)");
            num = int.Parse(Console.ReadLine());
            Operation<int> oper = null;

            if (num == 1)
            {
                oper = Addelement;
                Console.WriteLine("Ваш результат = " + oper.Invoke(firstnum, secondnum));
                
            }
            
            if (num == 2)
            {
                
                oper = Minuselement;
                Console.WriteLine("Ваш результат = " + oper.Invoke(firstnum, secondnum));

            }
            if (num == 3)
            {
                
                oper = Multiplyelemnt;
                Console.WriteLine("Ваш результат = " + oper.Invoke(firstnum, secondnum));

            }
            if (num == 4)
            {
                
                oper = devideelement;
                Console.WriteLine("Ваш результат = " + oper.Invoke(firstnum, secondnum));

            }
               
            









        }
    }
}
