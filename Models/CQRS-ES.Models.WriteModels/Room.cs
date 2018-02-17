using System;
using System.Collections.Generic;
using CQRS_ES.Events.Meetings;
using CQRS_ES.Events.Rooms;
using CQRSlite.Domain;

namespace CQRS_ES.Models.WriteModels
{
    public class Room : AggregateRoot
    {
        private Guid _roomId;
        private string _name;
        private string _description;
        private int _capacity;
        private bool _hasTV;
        private bool _hasBeamer;
        private string _email;
        private List<Guid> _meetings;

        public Room(Guid id, Guid roomId, string name, string description, int capacity, bool hasTV, bool hasBeamer, string email)
        {
            Id = id;
            _roomId = roomId;
            _name = name;
            _description = description;
            _capacity = capacity;
            _hasTV = hasTV;
            _hasBeamer = hasBeamer;
            _email = email;
            _meetings = new List<Guid>();
            ApplyChange(new RoomCreatedEvent(id, roomId, name, description, capacity, hasTV, hasBeamer, email));
        }

        public void AddMeeting(Guid meetingId)
        {
            _meetings.Add(meetingId);
            ApplyChange(new MeetingAssignedToRoomEvent(Id, _roomId, meetingId));
        }

        public void RemoveMeeting(Guid meetingId)
        {
            _meetings.Add(meetingId);
            ApplyChange(new MeetingRemovedFromRoomEvent(Id, _roomId, meetingId));
        }
    }
}