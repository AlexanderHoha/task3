using System;
using Task3._1.Interfaces;

namespace Task3._1.Models
{
    public class Candidate : BaseUser, IDisplayable
    {
        public Candidate()
        {
            
        }
        public Candidate(Guid id, string firstName, string lastName, string position, string positionDesc, double salary, int age)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            PositionDesc = positionDesc;
            Salary = salary;
            Age = age;
        }
        public new void Display()
        {
            Console.WriteLine($"Hello, i'm {Fullname}. I want to be a {Position} ({PositionDesc}) " +
                              $"with a salary from {Salary.ToString()}.");
        }

        public void DisplayShort()
        {
            Console.WriteLine($"{id.ToString()} | {Fullname} | {Position} | {Salary.ToString()}");
        }
    }
}