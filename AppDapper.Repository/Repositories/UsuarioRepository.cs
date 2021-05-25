using AppDapper.Domain.Entities;
using AppDapper.Domain.Interfaces.Repository;
using AppDapper.Repository.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDapper.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DbSession _dbSession;

        public UsuarioRepository(DbSession dbSession)
        {
            _dbSession = dbSession;
        }
        public async Task<List<Usuario>> GetAllAsync()
        {
            using (var conn = _dbSession.Connection)
            {
                string query = "GetUsuario";
                List<Usuario> usuarios = (await conn.QueryAsync<Usuario>(sql: query)).ToList();
                return usuarios;
            }
        }

        public async Task<Usuario> GetAsync(int id)
        {
            using (var conn = _dbSession.Connection)
            {
                string query = "SELECT * FROM Usuario WHERE Id = @id";
                Usuario usuario = await conn.QueryFirstOrDefaultAsync<Usuario>(sql: query, param: new { id });
                return usuario;
            }
        }

        public async Task<int> CreateAsync(Usuario entity)
        {
            using (var conn = _dbSession.Connection)
            {
                string command = @"INSERT INTO Usuario(Nome, Ativo) VALUES(@Nome, @Ativo)";
                var result = await conn.ExecuteAsync(sql: command, param: entity);
                return result;
            }
        }

        public async Task<int> UpdateAsync(Usuario entity)
        {
            using (var conn = _dbSession.Connection)
            {
                string command = @"UPDATE Usuario SET Nome = @Nome, Ativo = @Ativo WHERE Id = @Id";
                var result = await conn.ExecuteAsync(sql: command, param: entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = _dbSession.Connection)
            {
                string command = @"DELETE FROM Usuario WHERE Id = @Id";
                var result = await conn.ExecuteAsync(sql: command, param: new { id });
                return result;
            }
        }

    }
}
