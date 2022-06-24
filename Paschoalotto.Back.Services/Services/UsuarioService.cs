using Paschoalotto.Back.Domain.Entities;
using Paschoalotto.Back.Domain.Interfaces.Repository;
using Paschoalotto.Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paschoalotto.Back.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private IUsuarioRepository UsuarioRepository { get; set; }
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }

        public Usuario Salvar(Usuario usuario)
        {
            return base.Salvar(usuario);
        }

        public List<Usuario> Listar()
        {
            return base.Listar().ToList();
        }
    }
}
