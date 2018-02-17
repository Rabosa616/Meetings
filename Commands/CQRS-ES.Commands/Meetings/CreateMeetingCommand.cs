using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_ES.Commands.Meetings
{
    public class CreateMeetingCommand : BaseCommand
    {
        public readonly DateTime Begin;
        public readonly DateTime End;
        public readonly string Subject;
        public readonly string Description;
        public readonly Guid Organizer;
        public readonly Guid Room;
        public readonly bool IsPrivate;

        public CreateMeetingCommand(Guid id, 
                                    DateTime begin, 
                                    DateTime end, 
                                    string subject, 
                                    string description, 
                                    Guid organizer, 
                                    Guid room, 
                                    bool isPrivate)
        {
            Id = id;
            Begin = begin;
            End = end;
            Subject = subject;
            Description = description;
            Organizer = organizer;
            Room = room;
            IsPrivate = isPrivate;
        }
    }
}
