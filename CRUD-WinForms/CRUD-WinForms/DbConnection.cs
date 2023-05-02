using CRUD_WinForms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WinForms
{
    public class DbConnection : ICrud<Usuario>
    {
        public void Create(Usuario nuevoUsuario)
        {
            using var context = new UsuariosContext();
            context.Add(nuevoUsuario);
            context.SaveChanges();
        }

        public List<Usuario> Read()
        {
            using var context = new UsuariosContext();
            List<Usuario> listaUsuarios = context.Usuarios.ToList();
            return listaUsuarios;
        }

        public bool Update(Usuario usuarioActualizado)
        {
            using var context = new UsuariosContext();
            List<Usuario> listaUsuarios = Read();
            foreach (var item in listaUsuarios)
            {
                if (item.Dni == usuarioActualizado.Dni)
                {
                    context.Entry(usuarioActualizado).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public void Delete(int id)
        {
            using var context = new UsuariosContext();
            var usuario = Read().Where(x => x.Dni == id).First();
            context.Remove(usuario);
            context.SaveChanges();
        }


    }
}
