using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3dependencias.Interfaces
{
    public interface IConfigurable<T>
    {
        void Configure(T dep);
    }
}
