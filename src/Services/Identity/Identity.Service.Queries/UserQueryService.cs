using Identity.Persistence.Database;
using Identity.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Service.Queries
{
    public interface IUserQueryService
    {
        Task<DataCollection<UserDto>> GetAllAsync(int page, int take, IEnumerable<string> users = null);
        Task<UserDto> GetAsync(string id);
    }

    public class UserQueryService : IUserQueryService
    {
        private readonly ApplicationDBContext _context;

        public UserQueryService(
            ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<UserDto>> GetAllAsync(int page, int take, IEnumerable<string> users = null)
        {
            var collection = await _context.Users
                .Where(x => users == null || users.Contains(x.Id))
                .OrderBy(x => x.Nombre)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<UserDto>>();
        }

        public async Task<UserDto> GetAsync(string id)
        {
            return (await _context.Users.SingleAsync(x => x.Id == id)).MapTo<UserDto>();
        }
    }
}
