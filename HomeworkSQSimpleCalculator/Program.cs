using System;

namespace HomeworkSQSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalc calc = new SimpleCalc();
            Console.WriteLine("Rezultatul expresiei este: "+calc.Calculation);
        }
    }
}
