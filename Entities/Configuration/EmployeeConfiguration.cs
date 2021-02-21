using System;
using Bogus;
using Bogus.Extensions;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>

    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var guids = new[]
            {
                new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
            };
            var positions = new[] {"Software developer", "Administrator"};

            var employees = new Faker<Employee>()
                .RuleFor(p => p.Id, f => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Name.FullName())
                .RuleFor(p => p.Age, f => f.Random.Int(18, 60))
                .RuleFor(p => p.Position, f => f.PickRandom(positions))
                .RuleFor(p => p.CompanyId, f => f.PickRandom(guids));

            builder.HasData(employees.GenerateBetween(10, 10));
        }
    }
}