using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CHAINOFRESPONSABILITY.Interfaces
{
    public interface IResposabilidadBase
    {
        void GenerarResponsabilidad(string _cConcepto, int _dImporte);
    }
}
