using Ejercicio3Piramide.Servicios;

namespace Ejercicio3Piramide.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            MetodosInterfaz mi = new MetodosImplementacion();
            int numPedido = mi.pedirNumero();

            mi.piramide(numPedido);


        }

    }

}