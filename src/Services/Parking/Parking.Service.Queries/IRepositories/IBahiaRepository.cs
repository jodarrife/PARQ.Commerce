using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Service.Queries.DTOs;
using System.Threading.Tasks;

namespace Parking.Service.Queries.IRepositories
{
    public interface IBahiaRepository
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
