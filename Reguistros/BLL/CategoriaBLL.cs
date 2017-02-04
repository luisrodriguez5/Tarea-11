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
    public class CategoriaBLL
    {
        public static bool Guardar(Categoria categoria)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.categorias.Add(categoria);
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

        public static bool Eliminar(Categoria categoria)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.Entry(categoria).State = EntityState.Deleted;
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

        public static Categoria Buscar(int id)
        {
            var categoria = new Categoria();
            using (var db = new RegistroDb())
            {
                try
                {
                    categoria = db.categorias.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return categoria;
            }
        }

        public static List<Categoria> GetList()
        {
            List<Categoria> lista = new List<Categoria>();
            using (var db = new RegistroDb())
            {
                try
                {
                    if (db.categorias.ToList().Count > 0)
                    {
                        lista = db.categorias.ToList();
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
