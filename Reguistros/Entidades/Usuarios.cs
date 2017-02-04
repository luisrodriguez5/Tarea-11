using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reguistros.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(string clave, string nombre)
        {
            Nombre = nombre;
            Clave = clave;

        }
    }
}
