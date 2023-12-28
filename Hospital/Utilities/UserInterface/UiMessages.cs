﻿namespace Hospital.Utilities.UserInterface
{
    public static class UiMessages
    {
        //ManagePatients
        public static class CreatePatientMessages
        {
            public const string Introduce = "Admit a patient";
            public const string NoWardErrorPrompt = "No wards created to assign patient! Please create one first.";
            public const string OperationSuccessPrompt = "Patient {0} {1} admited sucesfully!";
        }

        public static class AssignToDoctorMessages
        {
            public const string Introduce = "Assign to doctor";
            public const string SelectPatientPrompt = "Pick for which patient you want assing doctor";
            public const string SelectDoctorPrompt = "Pick to which doctor you want to assing the patient";
            public const string NoDoctorsPrompt = "There is no doctor to assigned! Please add one first.";
            public const string OperationSuccessPrompt = "{0} {1} has been assgined to the {2} {3}";
            public const string WrongWardPrompt = "The doctor you want to assign to the patient is assigned to a different ward than the patient!";
        }

        public static class ChangeHealthStatusMessages
        {
            public const string Introduce = "Change health status";
            public const string SelectPatientPrompt = "Pick for which patient you want change health status";
            public const string OperationSuccessPrompt = "Health status of {0} {1} was changed successfully!";
        }

        public static class DisplayPatientsMessages
        {
            public const string Introduce = "Display all patients";
            public const string NoPatientsPrompt = "There is no patients in your hospital! Please add one first.";
        }

        public static class ManagePatientsMessages
        {
            public const string Introduce = "Manage patients";
        }

        public static class DeletePatientMessages
        {
            public const string Introduce = "Sign out patient";
            public const string DeletePrompt = "Pick which patient you want sign out.";
            public const string OperationSuccessPrompt = "Patient {0} {1} removed sucesfully!";
        }

        //ManageEmployees
        public static class DisplayEmployeesMessages
        {
            public const string Introduce = "Display employees";
            public const string NoEmployeesPrompt = "There is no employees in your hospital! Please add one first.";
        }

        public static class DeleteEmployeeMessages
        {
            public const string Introduce = "Fire employee";
            public const string SelectPrompt = "Pick which employee you want to fire.";
            public const string OperationSuccessPrompt = "{0} {1} {2} was fired successfully!";
            public const string NoEmployeesPrompt = "There is no employees to fire.";
        }

        public static class CreateEmployeeMessages
        {
            public const string Introduce = "Hire employee";
            public const string OperationSuccessPrompt = "{0} {1} {2} hired!";
            public const string ErrorCreateEmployeePrompt = "Error occured while trying to hire employee!";
            public const string UnsupportedEntityPrompt = "Unsupported entity type {0}.";
        }

        public static class ManageEmployeesMessages
        {
            public const string Introduce = "Manage employees";
        }

        //ManageWards
        public static class CreateWardMessages
        {
            public const string Introduce = "Add ward";
            public const string OperationSuccessPrompt = "Ward {0} created!";
        }

        public static class DeleteWardMessages
        {
            public const string Introduce = "Delete ward";
            public const string OperationSuccessPrompt = "Ward removed: {0}!";
            public const string WardNonEmptyPrompt = "Connot delete a ward to which patients or employees are assigned!";
            public const string SelectWardPrompt = "Select ward which you want to delete.";
            public const string NoWardPrompt = "There are no ward that can be deleted! Please create one first.";
        }

        public static class DisplayWardMessages
        {
            public const string Introduce = "Display wards";
            public const string NoWardPrompt = "There are no ward that can be displayed!";
        }

        public static class ManageWardsMessages
        {
            public const string Introduce = "Manage wards";
        }

        //ManageUsers
        public static class ManageUsersMessages
        {
            public const string Introduce = "Manage users";
        }

        public static class CreateUserCommandMessages
        {
            public const string Introduce = "Create account";
            public const string CreatedAccountPrompt = "User {0} created successfully!";
        }

        public static class DisplayUsersCommandMessages
        {
            public const string Introduce = "Display users";
        }

        public static class DeleteUserMessages
        {
            public const string Introduce = "Delete user";
            public const string NoUserPrompt = "There are no users that can be deleted! Please create one first.";
            public const string SelectUserPrompt = "Select user which you want to delete.";
            public const string OperationSuccessPrompt = "User {0} removed sucesfully!";
            public const string CurrentAccountErrorPrompt = "You cannot delete the account you are currently using!";
        }

        //Factory
        public static class FactoryMessages
        {
            public const string ProvideNamePrompt = "Enter a name: (Enter 'STOP' to abort the operation)";
            public const string ProvideSurnamePrompt = "Enter a surname: (Enter 'STOP' to abort the operation)";
            public const string EmptyFieldPrompt = "Field can't be empty!";
            public const string ProvideGenderPrompt = "Enter a gender (Male, Female): ";
            public const string InvalidGenderPrompt = "Invalid input. Please choose 'Male' or 'Female'.";
            public const string ProvidePeselPrompt = "Enter a PESEL: (Enter 'STOP' to abort the operation)";
            public const string InvalidPeselPrompt = "Invalid PESEL. It should be an 11-digit number. Please try again.";
            public const string ProvideBirthdayPrompt = "Enter a birthday (e.g., DD-MM-YYYY): (Enter 'STOP' to abort the operation)";
            public const string InvalidBirthdayPrompt = "Birthday cannot be a future date. Please try again.";
            public const string InvalidDateFormatPrompt = "Invalid date format. Please try again.";
            public const string InvalidDatePrompt = "Invalid date. Please try again.";
            public const string ProvideCapacityPrompt = "Please enter a positive capacity value: (Enter 'STOP' to abort the operation)";
            public const string NotValidNumberPrompt = "Please enter a valid number.";
            public const string FullWardPrompt = "This ward is full. Create a new one!";
            public const string ProvideLoginPrompt = "Enter login: (Enter 'STOP' to abort the operation)";
            public const string EmptyLoginPrompt = "Login can't be empty!";
            public const string TakenLoginPrompt = "This login already exists! Try a different one";
            public const string ProvidePasswordPrompt = "Enter password: (Enter 'STOP' to abort the operation)";
            public const string EmptyPasswordPrompt = "Password can't be empty!";
            public const string TooShortPasswordPrompt = "The password is too short. It must be at least 9 characters long.";
            public const string NoWardErrorPrompt = "No wards created to assign employee! Please create one first.";
            public const string AbortedOperationPrompt = "User aborted the operation.";
            public const string StopMessage = "stop";
        }

        //ExitCommand
        public static class ExitCommandMessages
        {
            public const string Introduce = "Exit";
        }

        //MainWindow
        public static class MainWindowMessages
        {
            public const string Introduce = "Main window";
        }

        //BackCommand
        public static class BackCommandMessages
        {
            public const string Introduce = "Go back";
        }

        //LoginWindow
        public static class LoginWindowCommandMessages
        {
            public const string Introduce = "Login window";
        }

        public static class LoginCommandMessages
        {
            public const string Introduce = "Login";
            public const string WrongPasswordPrompt = "Wrong password!";
            public const string CantFindLoginPrompt = "No user with this login found!";
        }

        public static class LogoutCommandMessages
        {
            public const string Introduce = "Logout";
        }

        //Entities
        public static class WardObjectMessages
        {
            public const string Introduce = "Ward: {0} [{1}/{2}]";
            public const string ProvideNamePrompt = "Provide ward name: ";
            public const string EmptyNamePrompt = "Name can't be empty.";
        }

        public static class UserObjectMessages
        {
            public const string Introduce = "User: {0}";
        }

        public static class PatientObjectMessages
        {
            public const string Introduce = "{0} {1} [{2}] - patient at {3}.";
        }

        public static class DoctorObjectMessages
        {
            public const string Introduce = "{0} {1} - {2} at {3} Ward.";
            public const string Position = "Doctor";
        }

        //Exceptions
        public static class DatabaseExceptions
        {
            public const string QueryException = "Exception occured while trying to gather data from database!";
            public const string ItemNull = "The provided item is null!";
            public const string AddException = "Exception occurred while adding: {0}!";
            public const string RemoveException = "Exception occurred while removing: {0}!";
            public const string ItemNotFound = "Item of type {0} with ID {1} not found in the list!";
            public const string UpdateException = "Exception occurred while updating: {0}!";
        }

        public static class ExceptionMessages
        {
            public const string String = "Invalid or empty value provided!";
            public const string Gender = "Invalid gender provided!";
            public const string Date = "Invalid date provided!";
            public const string Login = "Provided login already taken or empty!";
            public const string Password = "Provided password don't meet requirements!";
            public const string Pesel = "Provided pesel already taken or don't meet requirements!";
            public const string WardName = "Provided ward name already taken or don't meet requirements!";
            public const string Capacity = "Provided invalid capacity!";
            public const string Command = "Invalid command selected!";
            public const string EntityType = "Unsupported entity type {0}!";
            public const string DTOValidation = "DTO validation failed!";
            public const string WardFull = "Ward you want to assign patient is already full!";
            public const string OperationTerminated = "Operation terminated!";
        }

        public static class InputHandler
        {
            public const string StopMessage = "STOP";
        }
    }
}