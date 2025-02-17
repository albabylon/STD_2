using SOLIDTask.Calculating;
using SOLIDTask.Models;
using System;

namespace SOLIDTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ordAcc = new Account()
            {
                Balance = 700,
                Interest = 0,
                Type = "Обычный аккаунт"
            };

            var salAcc = new Account()
            {
                Balance = 3200,
                Interest = 0,
                Type = "Зарплатный аккаунт"
            };

            Calculator calculator = new Calculator();

            calculator.Calculate(new OrdinaryCalculator(ordAcc));
            calculator.Calculate(new SalaryCalculator(salAcc));

            Console.WriteLine($"{ordAcc.Type}: {ordAcc.Interest}");
            Console.WriteLine($"{salAcc.Type}: {salAcc.Interest}");
        }
    }
}
