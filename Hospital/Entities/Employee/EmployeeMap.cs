﻿using FluentNHibernate.Mapping;
using Hospital.PeopleCategories.PersonClass;

namespace Hospital.Entities.Employee
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Surname).Not.Nullable();
            Map(x => x.Gender).CustomType<Gender>().Not.Nullable();
            Map(x => x.Birthday).CustomType<DateTime>().Not.Nullable();
            Map(x => x.IntroduceString).Not.Nullable();
            Map(x => x.Position).CustomType<Position>().Not.Nullable();

            References(x => x.AssignedWard)
                .Column("WardId")
                .Not.Nullable();

            HasMany(x => x.AssignedPatients)
                .Inverse();
        }
    }
}