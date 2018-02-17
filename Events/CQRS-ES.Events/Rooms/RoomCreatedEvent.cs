using System;

namespace CQRS_ES.Events.Rooms
{
    public class RoomCreatedEvent : BaseEvent
    {
        public readonly string Name;
        public readonly string Description;
        public readonly int Capacity;
        public readonly bool HasTV;
        public readonly bool HasBeamer;
        public readonly string Email;

        public RoomCreatedEvent(Guid id, 
                               string name, 
                               string description, 
                               int capacity, 
                               bool hasTV, 
                               bool hasBeamer, 
                               string email)
        {
            Id = id;
            Name = name;
            Description = description;
            Capacity = capacity;
            HasTV = hasTV;
            HasBeamer = hasBeamer;
            Email = email;
        }
    }
}
