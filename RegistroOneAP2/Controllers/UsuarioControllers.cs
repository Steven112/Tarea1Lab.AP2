using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroOneAP2.Models;
using RegistroOneAP2.Data;
using System.Linq.Expressions;

namespace RegistroOneAP2.Controllers
{
    public class UsuarioControllers
    {
        public bool Guardar(Usuario usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (usuario.UsuarioId == 0)
            {
                paso = Insertar(usuario);
            }
            else
            {
                paso = Modificar(usuario);
            }
            return paso;

        }
        public bool Insertar(Usuario usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {

                db.Usuarios.Add(usuario);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception) { throw; }
            return paso;
        }
        public bool Modificar(Usuario usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.Usuarios.Add(usuario);
            db.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public Usuario Buscar(int Id)
        {
            Contexto db = new Contexto();
            Usuario usuario = new Usuario();
            try
            {
                usuario = db.Usuarios.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Usuario usuario = new Usuario();


            usuario = db.Usuarios.Find(Id);
            db.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public List<Usuario> GetAsignaturas(Expression<Func<Usuario, bool>> expression)
        {
            List<Usuario> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Usuarios.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
