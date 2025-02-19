using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Factory
    {

        public static Animal GetAnimal(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return new Cuadrupedo();

                case 2:
                    return new Ave();

                case 3:
                    return new Pez();

                default:

                    return null;
            }
        }
    }
}
