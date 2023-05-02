using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WinForms.Models
{
    public interface IUpdate<T>
    {
        public bool Update(Usuario usuarioActualizado);
    }
}
