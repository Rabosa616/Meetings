using System;
using System.Collections.Generic;
using CQRS_ES.Events.Meetings;
using CQRSlite.Domain;

namespace CQRS_ES.Models.WriteModels
{
    public class Meeting : AggregateRoot
    {
        private Guid _meetingId;
        private DateTime _begin;
        private DateTime _end;
        private string _subject;
        private string _description;
        private Guid _organizer;
        private Guid _room;
        private bool _isPrivate;
        private List<Guid> _attendees;

        public Meeting(Guid id, Guid meetingId, DateTime begin, DateTime end, string subject, string description, Guid organizer, bool isPrivate)
        {
            Id = id;
            _meetingId = meetingId;
            _begin = begin;
            _end = end;
            _subject = subject;
            _description = description;
            _organizer = organizer;
            _isPrivate = isPrivate;
            _attendees = new List<Guid>();
            ApplyChange(new MeetingCreatedEvent(id, meetingId, begin, end, subject, description, organizer, isPrivate));
        }

        public void AddAttendee(Guid attendee)
        {
            _attendees.Add(attendee);
            ApplyChange(new AttendeeAddedToMeetingEvent(Id, _meetingId, attendee));
        }

        public void RemoveAttendee(Guid attendee)
        {
            _attendees.Remove(attendee);
            ApplyChange(new AttendeeRemovedFromMeetingEvent(Id, _meetingId, attendee));
        }
    }
}
