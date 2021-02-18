using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task3._1.Models;

namespace Task3._1.Interfaces
{
    public interface IReportGenerator
    {
        public IEnumerable GenerateReport(IEnumerable<Employee> input);

        public IEnumerable GenerateReport(IEnumerable<Candidate> input);
    }
}