using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Service.Queries.DTOs;
using System.Threading.Tasks;

namespace Parking.Service.Queries.IRepositories
{
    public interface IParqueaderoRepository
    {
        //agregar
        Task CreateParqueadero(ParqueaderoDto parqueaderoDto);

        //Consultar individual
        Task GetParqueadero(ParqueaderoDto parqueaderoDto);

        //Consultar
        Task GetAllParqueaderos();

        //Eliminar
        Task DeleteParqueadero(int id);

        //Modificar
        Task UpdateParqueadero(ParqueaderoDto parqueaderoDto);

    }
}
