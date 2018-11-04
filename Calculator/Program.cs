using System;

namespace Calculator
{
    class Program
    {
        private static bool _continue = true; 
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор может производить вычисления: сложение +, вычитание -, умножение *, деление /");
            while(_continue)
            {
                Console.Write("Выберете оператора: ");
                var oper = Console.ReadLine();
                Console.Write("Введите первый аргумент: ");
                var firstArgument = decimal.Parse(Console.ReadLine());
                Console.Write("Введите второй аргумент: ");
                var secondArgument = decimal.Parse(Console.ReadLine());
                if (oper=="+")
                {
                    Console.WriteLine("Результат: {0}", Calculator.Sum(firstArgument, secondArgument));
                    
                }

                if (oper=="-")
                {
                    Console.WriteLine("Результат: {0}", Calculator.Sub(firstArgument, secondArgument));
                }

                if (oper=="*")
                {
                    Console.WriteLine("Результат: {0}", Calculator.Mul(firstArgument, secondArgument));
                }

                if (oper=="/")
                {
                    if (secondArgument==0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    else
                    {
                        Console.WriteLine("Результат: {0}", Calculator.Div(firstArgument, secondArgument));
                    }
                }
                Console.WriteLine("Продолжить? (Y/N)");
                var exitChoice = Console.ReadLine();
                if (exitChoice=="N")
                {
                    _continue = false;
                }
            }

            Console.ReadKey();
        }


        
    }
}
