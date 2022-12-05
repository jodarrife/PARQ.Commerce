using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Service.Queries.DTOs;

namespace Parking.Service.Queries.IServices
{
    public interface IBahiaService
    {
        //agregar
        Task CreateBahia(BahiaDto bahiaDto);

        //Consultar individual
        Task GetBahia(BahiaDto bahiaDto);

        //Consultar
        Task GetAllBahias();

        //Eliminar
        Task DeleteBahia(int id);

        //Modificar
        Task UpdateBahia(BahiaDto bahiaDto);

    }
}
