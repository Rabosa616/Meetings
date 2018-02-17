using System;
using System.Collections.Generic;
using CQRS_ES.Events.Meetings;
using CQRSlite.Domain;

namespace CQRS_ES.Models.WriteModels
{
    public class Meeting : AggregateRoot
    {
        private DateTime _begin;
        private DateTime _end;
        private string _subject;
        private string _description;
        private Guid _organizer;
        private Guid _room;
        private bool _isPrivate;
        private List<Guid> _attendees;

        public Meeting(Guid id, DateTime begin, DateTime end, string subject, string description, Guid organizer, bool isPrivate)
        {
            Id = id;
            _begin = begin;
            _end = end;
            _subject = subject;
            _description = description;
            _organizer = organizer;
            _isPrivate = isPrivate;
            _attendees = new List<Guid>();
            ApplyChange(new MeetingCreatedEvent(id, begin, end, subject, description, organizer, isPrivate));
        }
    }
}
