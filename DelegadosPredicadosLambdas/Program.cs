using System;

namespace DelegadosPredicadosLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creacion del objeto delegado apuntando a la clase bienvenida y metodo saludo
            
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //utilizacion del delegado para llamar al metodo saludoBiejvenida
            
            ElDelegado();
                
                
         }

        //Definición del objeto delegado

        delegate void ObjetoDelegado();
    }

    class MensajeBienvenida
    { 

    public static void SaludoBienvenida()
    {
            Console.WriteLine("Hola");
    }
    }

    class MensajeDespedida
    {

        public static void SaludoDespedidaa()
        {
            Console.WriteLine("Adios");
        }
    }
}
