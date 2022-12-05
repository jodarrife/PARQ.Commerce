using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Service.Queries.DTOs;

namespace Parking.Service.Queries.IServices
{
    public interface IVehiculoService
    {
        //agregar
        Task CreateVehiculo(VehiculoDto vehiculoDto);

        //Consultar individual
        Task GetVehiculo(VehiculoDto vehiculoDto);

        //Consultar
        Task GetAllVehiculo();

        //Eliminar
        Task DeleteVehiculo(int id);

        //Modificar
        Task UpdateVehiculo(VehiculoDto vehiculoDto);
    }
}
