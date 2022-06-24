using Paschoalotto.Back.Domain.Interfaces.Repository;
using Paschoalotto.Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paschoalotto.Back.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
    {

        protected IBaseRepository<TEntity> Repository { get; }

        protected BaseService(IBaseRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public TEntity Salvar(TEntity entity)
        {
            return Repository.Salvar(entity);
        }

        public IEnumerable<TEntity> Listar()
        {
            return Repository.Listar();
        }

    }
}
