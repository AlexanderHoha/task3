using System.Collections;
using System.Linq;
using Task3._1.Interfaces;
using Task3._1.Models;
using System.Collections.Generic;

namespace Task3._1.Utilities
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public IEnumerable GenerateReport(IEnumerable<Employee> input)
        {
            var sorted = input.OrderBy(e=>e.CompanyName)
                .ThenByDescending(e=>e.Salary);

            return sorted;
        }

        public IEnumerable GenerateReport(IEnumerable<Candidate> input)
        {
            var sorted = input.OrderBy(c => c.Position)
                .ThenBy(c => c.Salary);

            return sorted;
        }
    }
}