using Pattern.CHAINOFRESPONSABILITY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CHAINOFRESPONSABILITY.Servicios
{
    public class ResponsabilidadBase : IResposabilidadBase
    {
        public IResponsabilidad responsabilidad;

        public ResponsabilidadBase(IResponsabilidad _responsabilidad)
        {
            this.responsabilidad = _responsabilidad;
        }

        public void GenerarResponsabilidad(string _cConcepto, int _dImporte)
        {
            responsabilidad.GenerarDescripcion(_cConcepto, _dImporte);
        }
    }
}
