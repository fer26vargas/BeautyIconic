using BackendBeautyIconic.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendBeautyIconic.Services.SProducts
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<int> AddProduct()
        {
            throw new NotImplementedException();
        }
        public async Task<List<Products>> GetAll(int pageNumber, int pageSize)
        {
            try
            {
                // Calcula el índice del primer elemento en la página
                int startIndex = (pageNumber - 1) * pageSize;

                // Consulta la base de datos para obtener una página de productos
                var productos = await _appDbContext.Products
                    .Skip(startIndex)
                    .Take(pageSize)
                    .ToListAsync();

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos", ex);
            }
        }

        public Task<List<Favorites>> GetAllFavorites()
        {
            throw new NotImplementedException();
        }
    }
}
