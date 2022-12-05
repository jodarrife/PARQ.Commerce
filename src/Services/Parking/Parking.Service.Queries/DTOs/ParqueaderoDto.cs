using System;
using System.Collections.Generic;

namespace Parking.Service.Queries.DTOs
{
    public class ParqueaderoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<BahiaDto> listBahias { get; set; }
    }
}
