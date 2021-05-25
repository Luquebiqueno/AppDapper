using System;
using System.Collections.Generic;
using System.Text;

namespace AppDapper.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
