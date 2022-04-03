using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext _dbContext;

        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CoffeeShopModel>> List()
        {
            return await _dbContext.CoffeeShops
                .Select(e => new CoffeeShopModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    OpeningHours = e.OpeningHours,
                    Address = e.Address,
                })
                .ToListAsync();
        }
    }
}
