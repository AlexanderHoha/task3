using System;
using System.Collections.Generic;
using Bogus;
using Task3._1.Models;

namespace Task3._1.Factories
{
    public class CandidateFactory
    {
        public List<Candidate> GetCandidates(int count = 1)
        {
            return new Faker<Candidate>()
                .RuleFor(e => e.id, f => Guid.NewGuid())
                .RuleFor(e => e.Age, f => f.Random.Int(18, 65))
                .RuleFor(e => e.Position, f => f.Name.JobTitle())
                .RuleFor(e => e.Salary, f => f.Random.Int(500, 10000))
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.PositionDesc, f => f.Name.JobType())
                .Generate(count);
        }
    }
}