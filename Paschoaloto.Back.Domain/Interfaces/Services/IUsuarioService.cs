using Paschoalotto.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paschoalotto.Back.Domain.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Usuario Salvar(Usuario usuario);
        List<Usuario> Listar();
    }
}
