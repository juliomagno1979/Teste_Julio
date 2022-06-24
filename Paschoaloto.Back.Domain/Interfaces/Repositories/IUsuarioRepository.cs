using Paschoalotto.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paschoalotto.Back.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario Salvar(Usuario obj);

        IEnumerable<Usuario> Listar();
    }
}
