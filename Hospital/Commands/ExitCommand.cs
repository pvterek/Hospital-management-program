﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Commands.ManagePatients;
using Hospital.Utilities;

namespace Hospital.Commands
{
    /// <summary>
    /// Represents the command to exit the application.
    /// Inheriting from the <see cref="CompositeCommand"/> class.
    /// </summary>
    internal class ExitCommand : CompositeCommand
    {
        /// <summary>
        /// Holds a singleton instance of the <see cref="ExitCommand"/> class.
        /// </summary>
        private static ExitCommand? _instance;

        /// <summary>
        /// Gets the singleton instance of the <see cref="ExitCommand"/> class.
        /// </summary>
        internal static ExitCommand Instance => _instance ??= new ExitCommand(UIMessages.ExitCommandMessages.Introduce);

        /// <summary>
        /// Initializes a new instance of the <see cref="ExitCommand"/> class with a specified introduce string.
        /// </summary>
        /// <param name="introduceString">The message or string that introduces this command to the user.</param>
        private ExitCommand(string introduceString) : base(introduceString) { }

        /// <summary>
        /// Executes the logic to exit the application.
        /// </summary>
        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}