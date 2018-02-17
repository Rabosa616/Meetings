using System;

namespace CQRS_ES.Events.Meetings
{
    public class AttendeeAddedToMeetingEvent : BaseEvent
    {
        public readonly Guid NewMeetingId;
        public readonly Guid AttendeeId;

        public AttendeeAddedToMeetingEvent(Guid id, Guid newMettingId, Guid attendeeId)
        {
            Id = id;
            NewMeetingId = newMettingId;
            AttendeeId = attendeeId;
        }
    }
}
