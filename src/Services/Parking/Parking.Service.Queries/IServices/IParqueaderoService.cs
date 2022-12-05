using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Service.Queries.DTOs;

namespace Parking.Service.Queries.IServices
{
    public interface IParqueaderoService
    {
        //agregar
        Task CreateParqueadero(ParqueaderoDto parqueadero);

        //Consultar individual
        Task GetParqueadero(ParqueaderoDto cuestionario);

        //Consultar
        Task GetAllParqueaderos();

        //Eliminar
        Task DeleteParqueadero(ParqueaderoDto id);

        //Modificar
        Task UpdateParqueadero(ParqueaderoDto cuestionario);
    }
}
