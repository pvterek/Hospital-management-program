﻿using FluentNHibernate.Mapping;
using Hospital.PeopleCategories.PersonClass;

namespace Hospital.PeopleCategories.UserClass
{
    internal class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Surname).Not.Nullable();
            Map(x => x.Gender).CustomType<Gender>().Not.Nullable();
            Map(x => x.Birthday).CustomType<DateTime>().Not.Nullable();
            Map(x => x.Login).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.IntroduceString).Not.Nullable();

            References(x => x.AssignedWard);
        }
    }
}