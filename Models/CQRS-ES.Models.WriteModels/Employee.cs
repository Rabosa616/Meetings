using System;
using CQRSlite.Domain;

namespace CQRS_ES.Models.WriteModels
{
    public class Employee : AggregateRoot
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _jobTitle;
        private string _email;

        private Employee() { }

        public Employee(Guid id, int employeeID, string firstName, string lastName, DateTime dateOfBirth, string jobTitle, string email)
        {
            Id = id;
            _employeeID = employeeID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _jobTitle = jobTitle;
            _email = email;
        }
    }
}
