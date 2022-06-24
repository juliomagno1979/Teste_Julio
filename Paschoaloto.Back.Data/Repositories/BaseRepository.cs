using Microsoft.EntityFrameworkCore;
using Paschoalotto.Back.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paschoalotto.Back.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        PaschoalottoContext _Context;
        public TEntity Salvar(TEntity entidade)
        {
            _Context.Add(entidade);
            _Context.SaveChanges();
            return entidade;
        }

        public IQueryable<TEntity> Listar()
        {
            return _Context.Set<TEntity>().AsNoTracking().AsQueryable();
        }

    }
}
