using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CHAINOFRESPONSABILITY.Interfaces
{
    public interface IResponsabilidad
    {
        IResponsabilidad Siguiente(IResponsabilidad handler);
        void GenerarDescripcion(string _cConcepto, int _iImporte);
        void GeneraDescripcionDefault(string _cConcepto);

    }
}
