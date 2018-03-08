using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = "";
            var input2 = "";
            var num1 = 0;
            var num2 = 0;

            Console.WriteLine("Please enter your first number then press enter");
            input1 = Console.ReadLine();
            var isNumber1 = int.TryParse(input1, out num1);
            Console.WriteLine("Please enter your second number then press enter");
            input2 = Console.ReadLine();
            var isNumber2 = int.TryParse(input2, out num2);

            if (isNumber1 && isNumber2)
            {
                Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            }
            else
            {
                Console.WriteLine("Please make sure numbers were entered");
            }


            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            //done//
        }
    }
}
