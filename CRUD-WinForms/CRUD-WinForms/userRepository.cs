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
    public class userRepository : ICrud<Usuario>
    {
        public Usuario Create(Usuario nuevoUsuario)
        {
            using var context = new UsuariosContext();
            context.Add(nuevoUsuario);
            context.SaveChanges();
            return nuevoUsuario;
        }

        public List<Usuario> Read()
        {
            using var context = new UsuariosContext();
            return context.Usuarios.ToList();
        }

        public Usuario? Update(Usuario usuarioActualizado)
        {
            using var context = new UsuariosContext();
            var usuario = Read().Where(x => x.Dni == usuarioActualizado.Dni).First();

            if (usuario != null)
            {
                context.Entry(usuarioActualizado).State = EntityState.Modified;
                context.SaveChanges();
                return usuarioActualizado;
            }
            return null;
        }

        public Usuario Delete(Usuario unUsuario)
        {
            using var context = new UsuariosContext();
            var usuario = Read().Where(x => x.Dni == unUsuario.Dni).First();
            context.Remove(usuario);
            context.SaveChanges();
            return usuario;
        }


    }
}
