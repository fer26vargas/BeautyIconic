using BackendBeautyIconic.Models;

namespace BackendBeautyIconic.Services.SProducts
{
    public interface IProductService
    {
        Task<int> AddProduct();

        Task<List<Favorites>> GetAllFavorites();

        Task<List<Products>> GetAll(int pageNumber, int pageSize);
    }
}
