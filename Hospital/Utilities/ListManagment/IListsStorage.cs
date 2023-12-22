﻿using Hospital.Entities.Employee;
using Hospital.PeopleCategories.PatientClass;
using Hospital.PeopleCategories.UserClass;
using Hospital.PeopleCategories.WardClass;

namespace Hospital.Utilities.ListManagment
{
    public interface IListsStorage
    {
        List<Employee> Employees { get; }
        List<Ward> Wards { get; }
        List<Patient> Patients { get; }
        List<User> Users { get; }
        HashSet<string> Pesels { get; }
        HashSet<string> Logins { get; }
        HashSet<string> WardsNames { get; }
    }
}