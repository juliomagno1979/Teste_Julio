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
        public BaseRepository()
        {
        }

        public TEntity Salvar(TEntity entidade)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaschoalottoContext>();
            optionsBuilder.UseInMemoryDatabase("dbPaschoalotto");

            using (var context = new PaschoalottoContext(optionsBuilder.Options))
            {
                context.Add(entidade);
                context.SaveChanges();
                return entidade;
            }
        }

        public List<TEntity> Listar()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaschoalottoContext>();
            optionsBuilder.UseInMemoryDatabase("dbPaschoalotto");

            using (var context = new PaschoalottoContext(optionsBuilder.Options))
            {
                return context.Set<TEntity>().AsNoTracking().AsQueryable().ToList();
            }
        }

    }
}
