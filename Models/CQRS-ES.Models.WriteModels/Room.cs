using System;
using System.Collections.Generic;
using CQRS_ES.Events.Rooms;
using CQRSlite.Domain;

namespace CQRS_ES.Models.WriteModels
{
    public class Room : AggregateRoot
    {
        private string _name;
        private string _description;
        private int _capacity;
        private bool _hasTV;
        private bool _hasBeamer;
        private string _email;
        private List<Guid> _meetings;

        public Room(Guid id, string name, string description, int capacity, bool hasTV, bool hasBeamer, string email)
        {
            Id = id;
            _name = name;
            _description = description;
            _capacity = capacity;
            _hasTV = hasTV;
            _hasBeamer = hasBeamer;
            _email = email;
            _meetings = new List<Guid>();
            ApplyChange(new RoomCreatedEvent(id, name, description, capacity, hasTV, hasBeamer, email));
        }
    }
}
