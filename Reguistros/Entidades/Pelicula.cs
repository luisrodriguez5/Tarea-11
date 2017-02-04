using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reguistros.Entidades
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }
        public DateTime Estreno { get; set; }
        public string Descripcion { get; set; }
        public Categoria CategoriaId { get; set; }

        public Pelicula()
        {

        }
        public Pelicula(DateTime estreno, string descripcion, Categoria categoria)
        {

            Estreno = estreno;
            Descripcion = descripcion;
            CategoriaId = categoria;

        }

    }
}
