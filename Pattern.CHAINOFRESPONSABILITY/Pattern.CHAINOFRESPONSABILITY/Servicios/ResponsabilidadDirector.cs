using Pattern.CHAINOFRESPONSABILITY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CHAINOFRESPONSABILITY.Servicios
{
    public class ResponsabilidadDirector : IResponsabilidad
    {
        IResponsabilidad siguienteResponsabilidad;
        public IResponsabilidad Siguiente(IResponsabilidad _responsabilidad)
        {
            this.siguienteResponsabilidad = _responsabilidad;
            return _responsabilidad;
        }

        public void GenerarDescripcion(string _cConcepto, int _iImporte)
        {
            if (_iImporte > 15000 && _iImporte <= 50000)
            {
                Console.WriteLine(string.Format("{0} AUTORIZADA por el Director", _cConcepto));
            }
            else
            {
                this.GeneraDescripcionDefault(_cConcepto);
                if (this.siguienteResponsabilidad != null)
                    this.siguienteResponsabilidad.GenerarDescripcion(_cConcepto, _iImporte);

            }            
        }
        public void GeneraDescripcionDefault(string _cConcepto)
        {
            Console.WriteLine(string.Format("{0} DENEGADA", _cConcepto));
        }       
    }
}
