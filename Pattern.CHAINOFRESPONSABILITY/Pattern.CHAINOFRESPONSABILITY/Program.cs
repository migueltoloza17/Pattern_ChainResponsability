using Pattern.CHAINOFRESPONSABILITY.Interfaces;
using Pattern.CHAINOFRESPONSABILITY.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CHAINOFRESPONSABILITY
{
    class Program
    {
        static void Main(string[] args)
        {
            string cConceptoPago = string.Empty;
            int dImporte = (int)decimal.Zero;

            IResponsabilidad responsabilidad1;
            IResponsabilidad responsabilidad2;
            IResponsabilidad responsabilidad3;
            IResponsabilidad responsabilidad4;

            Console.WriteLine("Ingrese el concepto de la compra");
            cConceptoPago = Console.ReadLine();
            Console.WriteLine("Ingrese el monto de la compra");
            dImporte = Convert.ToInt32(Console.ReadLine());


            responsabilidad1 = new ResponsabilidadCoordinador();
            responsabilidad2 = new ResponsabilidadGerente();
            responsabilidad3 = new ResponsabilidadSubdirector();
            responsabilidad4 = new ResponsabilidadDirector();

            responsabilidad1.Siguiente(responsabilidad2);
            responsabilidad2.Siguiente(responsabilidad3);
            responsabilidad3.Siguiente(responsabilidad4);

            ResponsabilidadBase svrResponsabilidad = new ResponsabilidadBase(responsabilidad1);
            svrResponsabilidad.GenerarResponsabilidad(cConceptoPago, dImporte);
           
            Console.ReadKey();

        }
    }
}
