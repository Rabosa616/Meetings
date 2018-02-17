using System;

namespace CQRS_ES.Events.Meetings
{
    public class MeetingRemovedFromRoomEvent : BaseEvent
    {
        public readonly Guid OldRoomId;
        public readonly Guid MeetingId;

        public MeetingRemovedFromRoomEvent(Guid id, Guid oldRoomId, Guid meetingId)
        {
            Id = id;
            OldRoomId = oldRoomId;
            MeetingId = meetingId;
        }
    }
}
