using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paschoalotto.Back.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity>
    {
        TEntity Salvar(TEntity obj);

        List<TEntity> Listar();
    }
}
