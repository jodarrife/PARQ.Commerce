using MediatR;
using Parking.Domain.Models;
using Parking.Persistence.Database;
using Parking.Service.EventHandlers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parking.Service.EventHandlers
{
    public class ParqueaderoCreateEventHandler : INotificationHandler<ParqueaderoCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ParqueaderoCreateEventHandler (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ParqueaderoCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Parqueadero
            {
                Nombre = command.Nombre,
                Descripcion = command.Descripcion
            });

            await _context.SaveChangesAsync();
        }

    }
}
