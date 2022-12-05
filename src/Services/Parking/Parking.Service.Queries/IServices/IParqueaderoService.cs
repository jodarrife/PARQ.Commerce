using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Service.Queries.DTOs;
using Service.Common.Collection;

namespace Parking.Service.Queries.IServices
{
    public interface IParqueaderoService
    {
        //agregar
        Task CreateParqueadero(ParqueaderoDto parqueadero);

        //Consultar individual
        Task<ParqueaderoDto> GetParqueadero(int id);

        //Consultar
        Task<DataCollection<ParqueaderoDto>> GetAllParqueaderos(int page, int take, IEnumerable<int> parqueadero = null);

        //Eliminar
        Task DeleteParqueadero(ParqueaderoDto id);

        //Modificar
        Task UpdateParqueadero(ParqueaderoDto cuestionario);
    }
}
