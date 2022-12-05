using Parking.Persistence.Database;
using Parking.Service.Queries.DTOs;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Parking.Service.Queries.IServices;
using Service.Common.Collection;
using Microsoft.EntityFrameworkCore;
using Service.Common.Mapping;
using Service.Common.Paging;

namespace Parking.Service.Queries
{
    public class ParqueaderoQueryService : IParqueaderoService
    {
        private readonly ApplicationDbContext _context;
        public ParqueaderoQueryService(ApplicationDbContext context)
        {
            _context = context; 
        }


        public async Task CreateParqueadero(ParqueaderoDto parqueadero)
        {
            throw new NotImplementedException();
        }

        public async Task<ParqueaderoDto> GetParqueadero(int id)
        {
            return (await _context.Parqueadero.SingleAsync(x => x.Id == id)).MapTo<ParqueaderoDto>();
        }

        public async Task<DataCollection<ParqueaderoDto>> GetAllParqueaderos(int page, int take, IEnumerable<int> parqueadero = null)
        {
            var collection = await _context.Parqueadero
                .Where(x => parqueadero == null || parqueadero.Contains(x.Id))
                .OrderByDescending(x => x.Id)
                .GetPagedAsync(page, take);
            
            return collection.MapTo<DataCollection<ParqueaderoDto>>();  
        }

        public async Task DeleteParqueadero(ParqueaderoDto id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateParqueadero(ParqueaderoDto cuestionario)
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
