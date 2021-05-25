using AppDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDapper.Domain.Interfaces.Service
{
    public interface IUsuarioServico
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario> GetAsync(int id);
        Task<bool> CreateAsync(Usuario entity);
        Task<bool> UpdateAsync(Usuario entity);
        Task<bool> DeleteAsync(int id);
    }
}
