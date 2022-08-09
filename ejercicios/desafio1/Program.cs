using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Telefono T1 = new Telefono("iphone", " XR PRO ");
          //  Console.WriteLine("el  modelo es: " + T1.getModelo());
          //  Console.WriteLine("la marca es: " + T1.getMarca());
            T1.setNumeroTelefonico("3585986788");
           // Console.WriteLine("el numero de telefono es " + T1.getNumeroTelefonico());
            T1.setCodigoOperador(1);
            //Console.WriteLine("el codigo de operador es: " + T1.getCodigoOperador());
            Console.WriteLine(T1.Llamar());
            Console.WriteLine( T1.Llamar("tomy"));
            Console.WriteLine("el modelo del telefono es: " + T1.getModelo() + "la marca del telefono es: " + T1.getMarca() + "el numero del telefono es: " + T1.getNumeroTelefonico() + "el numero de operador es: " + T1.getCodigoOperador());
            
            Console.ReadKey();
            

        }
    }
}
