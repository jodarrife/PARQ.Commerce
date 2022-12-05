using System;
using System.Collections.Generic;

namespace Api.Gateway.Models.Parking.DTOs
{
    public class ParqueaderoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<BahiaDto> listBahias { get; set; }
    }
}
