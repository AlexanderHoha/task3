using System;
using System.Collections.Generic;
using Bogus;
using Task3._1.Interfaces;
using Task3._1.Models;
using Task3._1.Utilities;

namespace Task3._1.Factories
{
    public class UserFactory
    {
        public IEnumerable<IDisplayable> GetUsers(UserTypesEnum.UserTypes userType, int count = 1)
        {
            switch (userType)
            {
                case UserTypesEnum.UserTypes.Candidate:
                {
                    var candidateFactory = new CandidateFactory();
                    return candidateFactory.GetCandidates(count);
                }

                case UserTypesEnum.UserTypes.Employee:
                {
                    var employeeFactory = new EmployeeFactory();
                    return employeeFactory.GetEmployees(count);
                }
            }
            return null;
        }
    }
}