using BackendBeautyIconic.Models;

namespace BackendBeautyIconic.Services.SUsers
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext appDbContext)
        {
                _context = appDbContext;
        }
        public Task<int> AddProduct(Products product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Favorites>> GetAllFavorites()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IniciarSesion(string email, string password)
        {
            throw new NotImplementedException();
        }

    }
}
