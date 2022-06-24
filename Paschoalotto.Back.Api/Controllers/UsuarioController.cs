using Microsoft.AspNetCore.Mvc;
using Paschoalotto.Back.Domain.Entities;
using Paschoalotto.Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paschoalotto.Back.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        IUsuarioService Servico { get; }

        public UsuarioController(IUsuarioService servico)
        {
            Servico = servico;
        }

        /// <summary>
        /// Cria/Altera registro de usuários
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Salvar(Usuario usuario)
        {
            return new ObjectResult(Servico.Salvar(usuario));
        }

        /// <summary>
        /// Listagem de usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(Servico.Listar());
        }
    }
}
