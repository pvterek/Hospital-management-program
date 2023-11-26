﻿using Hospital.Commands.Navigation;
using Hospital.Entities.Interfaces;
using Hospital.Utilities.UserInterface;
using Hospital.Utilities.UserInterface.Interfaces;

namespace Hospital.Commands.ManageEmployees
{
    internal class ManageEmployeesCommand : CompositeCommand
    {
        private readonly Lazy<HireEmployeeCommand> _hireEmployeeCommand;
        private readonly Lazy<DisplayEmployeesCommand> _displayEmployeesCommand;
        private readonly Lazy<FireEmployeeCommand> _fireEmployeeCommand;
        private readonly Lazy<BackCommand> _backCommand;
        private readonly INavigationService _navigationService;
        private readonly IMenuHandler _menuHandler;

        public ManageEmployeesCommand(
            Lazy<HireEmployeeCommand> hireEmployeeCommand,
            Lazy<DisplayEmployeesCommand> displayEmployeesCommand,
            Lazy<FireEmployeeCommand> fireEmployeeCommand,
            Lazy<BackCommand> backCommand,
            INavigationService navigationService,
            IMenuHandler menuHandler)
            : base(UiMessages.ManageEmployeesMessages.Introduce)
        {
            _hireEmployeeCommand = hireEmployeeCommand;
            _displayEmployeesCommand = displayEmployeesCommand;
            _fireEmployeeCommand = fireEmployeeCommand;
            _backCommand = backCommand;
            _navigationService = navigationService;
            _menuHandler = menuHandler;
        }

        public override void Execute()
        {
            var commands = new List<IHasIntroduceString>
            {
                _hireEmployeeCommand.Value,
                _displayEmployeesCommand.Value,
                _fireEmployeeCommand.Value,
                _backCommand.Value
            };

            var selectedCommand = _menuHandler.ShowInteractiveMenu(commands);
            _navigationService.Queue((CompositeCommand)selectedCommand);

            switch (selectedCommand.IntroduceString)
            {
                case UiMessages.HireEmployeeMessages.Introduce:
                    _hireEmployeeCommand.Value.Execute();
                    break;
                case UiMessages.DisplayEmployeesMessages.Introduce:
                    _displayEmployeesCommand.Value.Execute();
                    break;
                case UiMessages.FireEmployeeMessages.Introduce:
                    _fireEmployeeCommand.Value.Execute();
                    break;
                case UiMessages.BackCommandMessages.Introduce:
                    _backCommand.Value.Execute(); 
                    break;
                default:
                    Console.WriteLine(UiMessages.ExceptionMessages.Command);
                    break;
            }
        }
    }
}