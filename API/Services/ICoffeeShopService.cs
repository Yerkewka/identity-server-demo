using API.Models;

namespace API.Services
{
    public interface ICoffeeShopService
    {
        Task<IEnumerable<CoffeeShopModel>> List();
    }
}
