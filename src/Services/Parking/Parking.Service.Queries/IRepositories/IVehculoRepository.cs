using Parking.Service.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Service.Queries.IRepositories
{
    public interface IVehiculoRepository
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
