using System;

namespace Calculator
{
    class Program
    {
        private static bool _continue = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор может производить вычисления: сложение +, вычитание -, умножение *, деление /, сложение двух двумерных массивов ArraySum");
            while (_continue)
            {
                Console.Write("Выберете оператора: ");
                var oper = Console.ReadLine();
                if (oper == "ArraySum")
                {
                    Console.Write("Введите длину внешнего массива");
                    var outerArrayLenght = int.Parse(Console.ReadLine());
                    Console.Write("Введите длину внутренних массивов");
                    var innerArrayLenght = int.Parse(Console.ReadLine());
                    var firstInputArray = new decimal[outerArrayLenght][];
                    var secondInputArray = new decimal[outerArrayLenght][];
                    Console.WriteLine("Заполните первый массив");
                    ArrayInput(firstInputArray, innerArrayLenght);
                    Console.WriteLine("Заполните второй массив");
                    ArrayInput(secondInputArray, innerArrayLenght);
                    Console.WriteLine("Полученный массив");
                    WriteArray(Calculator.ArraySum(firstInputArray, secondInputArray));
                }
                else
                {
                    Console.Write("Введите первый аргумент: ");
                    var firstArgument = decimal.Parse(Console.ReadLine());
                    Console.Write("Введите второй аргумент: ");
                    var secondArgument = decimal.Parse(Console.ReadLine());
                    if (oper == "+")
                    {
                        Console.WriteLine("Результат: {0}", Calculator.Sum(firstArgument, secondArgument));
                    }

                    if (oper == "-")
                    {
                        Console.WriteLine("Результат: {0}", Calculator.Sub(firstArgument, secondArgument));
                    }

                    if (oper == "*")
                    {
                        Console.WriteLine("Результат: {0}", Calculator.Mul(firstArgument, secondArgument));
                    }

                    if (oper == "/")
                    {
                        if (secondArgument == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine("Результат: {0}", Calculator.Div(firstArgument, secondArgument));
                        }
                    }
                }

                Console.WriteLine("Продолжить? (Y/N)");
                var exitChoice = Console.ReadLine();
                if (exitChoice == "N")
                {
                    _continue = false;
                }
            }

            Console.ReadKey();
        }

        private static void ArrayInput(decimal[][] array, int innerArrayLength)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= new decimal[innerArrayLength];
                for (int j = 0; j < innerArrayLength; j++)
                {
                    Console.Write("Введите [{0}] [{1}]", i, j);
                    array[i][j] = decimal.Parse(Console.ReadLine());
                }
            }
        }

        private static void WriteArray(decimal[][] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[");
                for (int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(array[i][j]);
                    if (j != array[i].Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                if (i != array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }
    }
}
