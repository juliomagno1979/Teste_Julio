using Microsoft.AspNetCore.Mvc;
using Paschoalotto.Back.Domain.Entities;
using Paschoalotto.Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paschoalotto.Back.Api.Controllers
{
    public class UsuarioController : Controller
    {
        IUsuarioService Servico { get; }

        [HttpPost]
        public IActionResult Salvar(Usuario usuario)
        {
            return Ok(Servico.Salvar(usuario));
        }
    }
}
