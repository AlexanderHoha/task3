using System;
using System.Collections.Generic;
using System.Linq;
using Task3._1.Factories;
using Task3._1.Models;
using Task3._1.Utilities;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var userFactory = new UserFactory();
            var employees = userFactory.GetUsers(UserTypesEnum.UserTypes.Employee, rand.Next(1, 5));
            var candidates = userFactory.GetUsers(UserTypesEnum.UserTypes.Candidate, rand.Next(1, 5));
            
            foreach (var e in employees)
            {
                e.Display();
            }

            foreach (var c in candidates)
            {
                c.Display();
            }
            
            //#6
            var employeeReportGenerator = new EmployeeReportGenerator();
            List<Employee> listEmps = new List<Employee>();
            List<Candidate> listCands = new List<Candidate>();
            
            listEmps.Add(new Employee(Guid.NewGuid(), "Alex", "Hoha", "Junior QAA",
                    "Automated testing", 300, 22, "ITA", "BY", "Minsk","Pritickogo"));
            listEmps.Add(new Employee(Guid.NewGuid(), "Petya", "Pupkin", "Junior QAA",
                "Automated testing", 88, 22, "ITA", "BY", "Minsk","Pritickogo"));
            listEmps.Add(new Employee(Guid.NewGuid(), "Vasya", "Ivanov", "Junior QAA",
                "Automated testing", 111, 22, "ITA", "BY", "Minsk","Pritickogo"));
            listEmps.Add(new Employee(Guid.NewGuid(), "Ivan", "Krupnik", "PM",
                "BA", 200, 22, "AAA", "RU", "Moscow","Pritickogo"));
            listEmps.Add(new Employee(Guid.NewGuid(), "Oleg", "Hoha", "PM",
                "BA", 310, 22, "AAA", "RU", "Moscow","Pritickogo"));

            listCands.Add(new Candidate(Guid.NewGuid(), "Lara","Croft", "Grade3",
                "Grade3 Desc", 100,20));
            listCands.Add(new Candidate(Guid.NewGuid(), "Nathen","Drake", "Grade2",
                "Grade2 Desc", 80,20));
            listCands.Add(new Candidate(Guid.NewGuid(), "Tom","Soyer", "Grade2",
                "Grade2 Desc", 110,20));
            
            var sortedEmps = employeeReportGenerator.GenerateReport(listEmps);
            var sortedCands = employeeReportGenerator.GenerateReport(listCands);

            foreach (Employee e in sortedEmps)
            {
                e.DisplayShort();
            }
            
            foreach (Candidate c in sortedCands)
            {
                c.DisplayShort();
            }
        }
    }
}