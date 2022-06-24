using System;
using System.Collections.Generic;
using System.Text;

namespace Paschoalotto.Back.Domain.Entities
{
    public class Usuario
    {
        public int? Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Endereco { get; set; }
        public int? Idade { get; set; }
    }
}
