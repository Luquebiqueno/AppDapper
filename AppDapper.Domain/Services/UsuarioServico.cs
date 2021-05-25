using AppDapper.Domain.Entities;
using AppDapper.Domain.Interfaces.Repository;
using AppDapper.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDapper.Domain.Services
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServico(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetAsync(int id)
        {
            return await _usuarioRepository.GetAsync(id);
        }

        public async Task<bool> CreateAsync(Usuario entity)
        {
            var result = await _usuarioRepository.CreateAsync(entity);

            if(result > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Usuario entity)
        {
            var result = await _usuarioRepository.UpdateAsync(entity);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _usuarioRepository.DeleteAsync(id);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
