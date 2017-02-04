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
    public class UsuariosBLL
    {

        public static bool Guardar(Usuarios usuario)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.usuario.Add(usuario);
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

        public static bool Eliminar(Usuarios usuario)
        {
            using (var db = new RegistroDb())
            {
                try
                {
                    db.Entry(usuario).State = EntityState.Deleted;
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

        public static Usuarios Buscar(int id)
        {
            var usuario = new Usuarios();
            using (var db = new RegistroDb())
            {
                try
                {
                    usuario = db.usuario.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
            }
        }

        public static List<Usuarios> GetList()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (var db = new RegistroDb())
            {
                try
                {
                    if (db.usuario.ToList().Count > 0)
                    {
                        lista = db.usuario.ToList();
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
