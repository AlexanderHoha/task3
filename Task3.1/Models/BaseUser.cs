using System;

namespace Task3._1.Models
{
    public class BaseUser
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PositionDesc { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        
        public string Fullname => FirstName + " " + LastName;

        public void Display()
        {
            Console.WriteLine(Fullname);
        }
    }
}