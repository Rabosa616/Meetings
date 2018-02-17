using System;

namespace CQRS_ES.Commands.Employees
{
    public class CreateEmployeeCommand : BaseCommand
    {
        public readonly int EmployeeID;
        public readonly string FirstName;
        public readonly string LastName;
        public readonly DateTime DateOfBirth;
        public readonly string JobTitle;
        public readonly string Email;

        public CreateEmployeeCommand(Guid id,
                                     int employeeID,
                                     string firstName,
                                     string lastName,
                                     DateTime dateOfBirth,
                                     string jobTitle,
                                     string email)
        {
            Id = id;
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
            Email = email;
        }
    }
}
