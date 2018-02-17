using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_ES.Events.Meetings
{
    public class MeetingCreatedEvent : BaseEvent
    {
        public readonly Guid MeetingId;
        public readonly DateTime Begin;
        public readonly DateTime End;
        public readonly string Subject;
        public readonly string Description;
        public readonly Guid Organizer;
        public readonly bool IsPrivate;

        public MeetingCreatedEvent(Guid id,
                                   Guid meetingId,
                                   DateTime begin,
                                   DateTime end,
                                   string subject,
                                   string description,
                                   Guid organizer,
                                   bool isPrivate)
        {
            Id = id;
            MeetingId = meetingId;
            Begin = begin;
            End = end;
            Subject = subject;
            Description = description;
            Organizer = organizer;
            IsPrivate = isPrivate;
        }
    }
}
