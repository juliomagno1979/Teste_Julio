﻿using Paschoalotto.Back.Domain.Entities;
using Paschoalotto.Back.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paschoalotto.Back.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public Usuario Salvar(Usuario usuario)
        {

            return usuario;
        }

        public IEnumerable<Usuario> Listar()
        {

            return null;
        }
    }
}
