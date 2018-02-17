using System;

namespace CQRS_ES.Events.Meetings
{
    public class MeetingAssignedToRoomEvent : BaseEvent
    {
        public readonly Guid NewRoomId;
        public readonly Guid MeetingId;

        public MeetingAssignedToRoomEvent(Guid id, Guid newRoomId, Guid meetingId)
        {
            Id = id;
            NewRoomId = newRoomId;
            MeetingId = meetingId;
        }
    }
}
