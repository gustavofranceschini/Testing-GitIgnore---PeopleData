using System;
using System.Globalization;

namespace PeopleData.Entities
{
    class Data
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DayBirth { get; set; }
        public double BaseSalary { get; set; }
        public double BaseSalaryIncrease { get; set; }

        public Data()
        {
        }

        public Data(string name, int age, DateTime dayBirth, double baseSalary)
        {
            Name = name;
            Age = age;
            DayBirth = dayBirth;
            BaseSalary = baseSalary;
        }

        public void IncreaseSalary(double porcentage)
        {
            BaseSalaryIncrease += BaseSalary + (BaseSalary / 100 * porcentage); 
        }

        public override string ToString()
        {
            return "People data:\n"
                + "Name: "
                + Name
                + "\nAge: "
                + Age
                + "\nDay Birth: "
                + DayBirth.ToShortDateString()
                + "\nSalary before increase: R$ "
                + BaseSalary.ToString("F2", CI)
                +"\nSalary after increase: R$ "
                + BaseSalaryIncrease.ToString("F2", CI);
                
            
                
                
                
        }
    }
}
