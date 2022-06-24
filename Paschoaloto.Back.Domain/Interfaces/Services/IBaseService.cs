using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paschoalotto.Back.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
    {
        TEntity Salvar(TEntity obj);
        List<TEntity> Listar();
    }
}
