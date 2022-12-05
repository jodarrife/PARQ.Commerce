using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Service.EventHandlers.Commands
{
    public class ParqueaderoCreateCommand :INotification
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
