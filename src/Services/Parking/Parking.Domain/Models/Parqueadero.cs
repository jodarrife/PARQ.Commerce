using System;
using System.Collections.Generic;

namespace Parking.Domain.Models
{
    public class Parqueadero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Bahia> listBahias { get; set; }
    }
}
