using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseExcepcion
{
    public class MiClase
    {
        public static void ExepcionDivisionCero()
        {
            throw new DivideByZeroException("Fallo1");
        }

        public MiClase(string nombre)
        {

        }

        public MiClase()
        {
            try
            {
                MiClase.ExepcionDivisionCero();
            }
            catch(DivideByZeroException a)
            {
                throw a;
            }
        }

        public MiClase(int x) 
        {
            try
            {
                new MiClase();
            }
            catch(DivideByZeroException a)
            {
               throw new UnaExcepcion("Fallo2", a);
            }
        }

        public void MiMetodo()
        {
            try
            {
                new MiClase(2);
            }
            catch(Exception e)
            {
               throw new MiException("Fallo3", e);
            }
        }
    }
}
