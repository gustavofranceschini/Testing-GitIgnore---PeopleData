using System;
using System.Globalization;
using PeopleData.Entities;

namespace PeopleData
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter data people:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Day Birth: ");
            DateTime dayBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Base Salary: R$ ");
            double baseSalary = double.Parse(Console.ReadLine(), CI);
            Console.Write("Percentage increase: ");
            double percentage = double.Parse(Console.ReadLine(), CI);

            Data people = new Data(name, age, dayBirth, baseSalary);
            people.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine(people);
            
            
            
        }
    }
}
