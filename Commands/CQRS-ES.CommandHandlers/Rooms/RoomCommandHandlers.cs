using CQRS_ES.Commands.Rooms;
using CQRS_ES.Models.WriteModels;
using CQRSlite.Commands;
using CQRSlite.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_ES.CommandHandlers.Rooms
{
    public class RoomCommandHandlers : ICommandHandler<CreateRoomCommand>
    {
        private readonly ISession _session;

        public RoomCommandHandlers(ISession session)
        {
            _session = session;
        }

        public async Task Handle(CreateRoomCommand command)
        {
            Room room = new Room(command.Id, command.Name, command.Description, command.Capacity, command.HasTV, command.HasBeamer, command.Email);
            await _session.Add(room);
            await _session.Commit();
        }
    }
}
