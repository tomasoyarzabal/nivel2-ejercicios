using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Telefono
    {
        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperador;
        
       //propiedades.
        public string getModelo()
        {
            return Modelo;
        }
        public string getMarca()
        {
            return Marca;
        }
        public string getNumeroTelefonico()
        {
            return NumeroTelefonico;
        }
        public void setNumeroTelefonico(string numero)
        {
            NumeroTelefonico = numero;
        }
        public int  getCodigoOperador()
        {
            return CodigoOperador;  
        }
        public void setCodigoOperador(int codigo)
        {
            if(codigo > 0 && codigo < 4)
            {
                CodigoOperador = codigo;
            }
            
        }
        //constructor.

        public Telefono(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
        //destructor.
        public Telefono() { }

        //metodos.
        public string Llamar()
        {
            return "realizando llamada...";
        }
        //sobrecarga de metodo.
        public string Llamar(string contacto)
        {
            return "llamando a " + contacto;
        }
    }
}
