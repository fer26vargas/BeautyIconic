using BackendBeautyIconic.Models;

namespace BackendBeautyIconic.Services.SUsers
{
    public interface IUserService
    {
        Task<bool>IniciarSesion(string email, string password);
        Task<List<Favorites>> GetAllFavorites();
        Task<int> AddProduct(Products product);

    }
}
