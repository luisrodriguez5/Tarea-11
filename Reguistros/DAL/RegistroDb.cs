using Reguistros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reguistros.DAL
{
   public class RegistroDb: DbContext
    {
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Pelicula> pelicula  { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
        public object Categorias { get; internal set; }

        public RegistroDb() : base ("ConStr")
        {

        }

    }
}
