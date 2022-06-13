using System;
using System.Globalization;

namespace Exercise_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que ler Nº de funcionário, horas trabalhadas e quanto recebe por hora
            //Calculando também o salário desse funcionário
            int nºFunc = int.Parse(Console.ReadLine());
            int htraba = int.Parse(Console.ReadLine());
            double vlphora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario=0.0;

            salario = htraba * vlphora;
            Console.WriteLine("Number: " + nºFunc);
            Console.WriteLine("Salary: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
