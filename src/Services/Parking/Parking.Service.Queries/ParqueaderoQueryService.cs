using Parking.Persistence.Database;
using Parking.Service.Queries.DTOs;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Parking.Service.Queries.IServices;

namespace Parking.Service.Queries
{
    public class ParqueaderoQueryService : IParqueaderoService
    {
        private readonly ApplicationDbContext _context;
        public ParqueaderoQueryService(ApplicationDbContext context)
        {
            _context = context; 
        }


        public Task CreateParqueadero(ParqueaderoDto parqueadero)
        {
            throw new NotImplementedException();
        }

        public Task GetParqueadero(ParqueaderoDto cuestionario)
        {
            throw new NotImplementedException();
        }

        public Task GetAllParqueaderos()
        {
            throw new NotImplementedException();
        }

        public Task DeleteParqueadero(ParqueaderoDto id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateParqueadero(ParqueaderoDto cuestionario)
        {
            throw new NotImplementedException();
        }

        /*Agregar
        public async Task CreateParqueadero(ParqueaderoDto parqueaderoDto)
        {
            _context.Add(parqueaderoDto);
            await _context.SaveChangesAsync();
        }
       
        //obtener elo Parqueadero y Bahia 
        public async Task<ParqueaderoDto> GetParqueadero(int idParqueaderoDto)
        {
         
           
            var parqueaderoDto = await _context.ParqueaderoDto.Where(x => x.Id == idParqueaderoDto
                    && x.Activo == 1)
                    .Include(x => x.listPreguntas)
                    .ThenInclude(x => x.listRespuestas)
                    .FirstOrDefaultAsync();
            return parqueaderoDto;
        }
        //BuscarCuestionario para eliminar
        public async Task<ParqueaderoDto> BuscarCuestionario(int idCuestionario, int idUsuario)
        {
            var parqueadero = await _context.ParqueaderoDto.Where(x => x.Id == idCuestionario
                                    && x.Activo == 1
                                    && x.UsuarioId == idUsuario).FirstOrDefaultAsync();
            return parqueadero;
        }
        //Eliminar Cuestionario
        public async Task EliminarParqueadero(ParqueaderoDto parqueaderoDto)
        {
            //cambiamos el estado
            //cuestionario.Activo = 0;

            //eliminamos logicamente
            _context.Entry(parqueaderoDto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }*/

        
    }
}
