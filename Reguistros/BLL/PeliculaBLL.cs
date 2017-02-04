using Reguistros.DAL;
using Reguistros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reguistros.BLL
{
    public class PeliculaBLL
    {
        public static bool Guardar(Pelicula peliculas)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.pelicula.Add(peliculas);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                return false;
            }
        }

        public static bool Eliminar(Pelicula peliculas)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.Entry(peliculas).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                return false;
            }
        }

        public static Pelicula Buscar(int id)
        {
            var pelicula = new Pelicula();
            using (var db = new RegistroDb())
            {
                try
                {
                    pelicula = db.pelicula.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return pelicula;
            }
        }

        public static List<Pelicula> GetList()
        {
            List<Pelicula> lista = new List<Pelicula>();
            using (var db = new RegistroDb())
            {
                try
                {
                    if (db.pelicula.ToList().Count > 0)
                    {
                        lista = db.pelicula.ToList();
                    }
                    else
                    {
                        lista = null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return lista;
            }
        }
    }
}
