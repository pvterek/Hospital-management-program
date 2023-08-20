﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Objects.PersonObject;
using Hospital.Objects.WardObject;
using Hospital.Utilities;

namespace Hospital.Objects.DoctorObject
{
    /// <summary>
    /// Represents a doctor working in the hospital. Inherits from the <see cref="Person"/> class and implements the <see cref="IEmployee"/> interface.
    /// </summary>
    internal class Doctor : Person, IEmployee
    {
        /// <summary>
        /// Gets the ward assigned to the doctor.
        /// </summary>
        internal Ward AssignedWard { get; private set; }

        /// <summary>
        /// Gets the position of the doctor.
        /// </summary>
        public string Position => "Doctor";

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class with the provided parameters.
        /// </summary>
        /// <param name="name">The first name of the doctor.</param>
        /// <param name="surname">The last name of the doctor.</param>
        /// <param name="gender">The gender of the doctor.</param>
        /// <param name="birthday">The birthdate of the doctor.</param>
        /// <param name="ward">The ward to which the doctor is initially assigned.</param>
        public Doctor(string name, string surname, Gender gender, DateTime birthday, Ward ward)
            : base(name, surname, gender, birthday)
        {
            AssignedWard = ward;
            IntroduceString = $"{Name} {Surname} - {Position} at {AssignedWard.Name} Ward";
        }

        /// <summary>
        /// Assigns the doctor to a new ward.
        /// </summary>
        /// <param name="newWard">The ward to which the doctor is to be assigned.</param>
        /// <exception cref="ArgumentException">Thrown when the provided ward is null.</exception>
        public void AssignToWard(Ward newWard)
        {
            if (newWard != null)
            {
                AssignedWard = newWard;
            }
            else
            {
                throw new ArgumentException(UIMessages.WardObjectMessages.NullPrompt);
            }
        }
    }
}