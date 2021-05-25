using AppDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDapper.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario> GetAsync(int id);
        Task<int> CreateAsync(Usuario entity);
        Task<int> UpdateAsync(Usuario entity);
        Task<int> DeleteAsync(int id);
    }
}
