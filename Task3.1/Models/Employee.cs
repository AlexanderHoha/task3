using System;
using System.Collections;
using Task3._1.Interfaces;

namespace Task3._1.Models
{
    public class Employee : BaseUser, IDisplayable
    {
        public Employee()
        {
            
        }
        public Employee(Guid id, string firstName, string lastName, string position, string positionDesc, double salary, 
            int age, string companyName, string companyCountry, string companyCity, string companyStreet)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            PositionDesc = positionDesc;
            Salary = salary;
            Age = age;
            CompanyName = companyName;
            CompanyCountry = companyCountry;
            CompanyCity = companyCity;
            CompanyStreet = companyStreet;
        }
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyStreet { get; set; }

        public new void Display()
        {
            Console.WriteLine($"Hello, I'm {Fullname}, {Position} in {CompanyName}, ({CompanyCountry}, {CompanyCity}, {CompanyStreet}) and " +
                              $"and my salary is {Salary.ToString()}.");
        }

        public void DisplayShort()
        {
            Console.WriteLine($"{id.ToString()} | {CompanyName} | {Fullname} | {Salary.ToString()}");
        }
    }
}