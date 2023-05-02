using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WinForms.Models
{
    public interface IRead<T>
    {
        public List<T> Read();
    }
}
