using System;

namespace CQRS_ES.Events.Meetings
{
    public class AttendeeRemovedFromMeetingEvent : BaseEvent
    {
        public readonly Guid Attendee;
        public readonly Guid OldMeetingId;

        public AttendeeRemovedFromMeetingEvent(Guid id, Guid oldMeetingId, Guid attendee)
        {
            Id = id;
            OldMeetingId = oldMeetingId;
            Attendee = attendee;
        }
    }
}
