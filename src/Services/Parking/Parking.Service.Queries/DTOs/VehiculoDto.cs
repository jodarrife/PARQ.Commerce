﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Service.Queries.DTOs
{
    public class VehiculoDto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Placa { get; set; }
    }
}
