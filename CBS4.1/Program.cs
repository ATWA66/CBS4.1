using System;

namespace CBS4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operand 1");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operand 2");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter operetion:");
            double res = 0;
            switch(Console.ReadLine())
            {
                case "+":
                    {
                        res = operand1 += operand2;
                        break;
                    }
                case "-":
                    {
                        res = operand1 -= operand2;
                        break;
                    }
                case "*":
                    {
                        res = operand1 *= operand2;
                        break;
                    }
                case "/":
                    {
                        if (operand2 != 0)
                            res = operand1 /= operand2;
                        else
                            Console.WriteLine("an error occured");
                        break;
                    }
                case "%":
                    {
                        if (operand2 != 0)
                            res = operand1 %= operand2;
                        else
                            Console.WriteLine("an error occured");
                        break;
                    }
            }
            Console.WriteLine("result:" + res);
        }
    }
}
