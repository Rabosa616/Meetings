using CQRS_ES.Commands.Employees;
using CQRS_ES.Models.WriteModels;
using CQRSlite.Commands;
using CQRSlite.Domain;
using System.Threading.Tasks;

namespace CQRS_ES.CommandHandlers.Employees
{
    public class EmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand>
    {
        private readonly ISession _session;

        public EmployeeCommandHandler(ISession session)
        {
            _session = session;
        }

        public async Task Handle(CreateEmployeeCommand command)
        {
            Employee employee = new Employee(command.Id, 
                                             command.EmployeeID, 
                                             command.FirstName,
                                             command.LastName, 
                                             command.DateOfBirth, 
                                             command.JobTitle, 
                                             command.Email);
            await _session.Add(employee);
            await _session.Commit();
        }
    }
}
