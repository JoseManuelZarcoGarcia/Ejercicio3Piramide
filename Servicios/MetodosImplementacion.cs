using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Piramide.Servicios
{
    internal class MetodosImplementacion : MetodosInterfaz
    {

        public void piramide(int numeroPedido)
        {
            string aux ="";

            for (int i = 1; i <= numeroPedido; i++)
            {
                aux = aux + i;

                Console.WriteLine(aux);
            }

        }

        public int pedirNumero()
        {
            Console.Write("Escriba un nuemro entero mayor a 0: ");
            int numeroPedido = Convert.ToInt32(Console.ReadLine());
            return numeroPedido;
        }

    }
}
