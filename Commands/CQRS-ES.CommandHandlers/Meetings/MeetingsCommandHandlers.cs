using CQRS_ES.Commands.Meetings;
using CQRS_ES.Models.WriteModels;
using CQRSlite.Commands;
using CQRSlite.Domain;
using System.Threading.Tasks;

namespace CQRS_ES.CommandHandlers.Meetings
{
    public class MeetingsCommandHandlers : ICommandHandler<CreateMeetingCommand>
    {
        private readonly ISession _session;

        public MeetingsCommandHandlers(ISession session)
        {
            _session = session;
        }
        public async Task Handle(CreateMeetingCommand command)
        {
            Meeting meeting = new Meeting(command.Id, 
                                          command.Begin, 
                                          command.End, 
                                          command.Subject, 
                                          command.Description, 
                                          command.Organizer, 
                                          command.IsPrivate);
            await _session.Add(meeting);
            await _session.Commit();
        }
    }
}
