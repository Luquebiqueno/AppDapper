using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDapper.Domain.Entities;
using AppDapper.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _usuarioServico.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioServico.GetAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] Usuario entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (entity == null)
                return BadRequest();

            var result = await _usuarioServico.CreateAsync(entity);

            if (!result)
                return BadRequest();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuario([FromBody] Usuario entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioServico.UpdateAsync(entity);

            if (!result)
                return BadRequest();

            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var result = await _usuarioServico.DeleteAsync(id);

            if (!result)
                return BadRequest();

            return Ok(result);
        }
    }
}
