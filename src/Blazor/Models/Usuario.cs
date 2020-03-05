using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario Tipo { get; set; }

    }
}
