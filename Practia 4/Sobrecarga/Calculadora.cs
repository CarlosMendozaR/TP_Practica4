using System;

namespace Sobrecarga
{
    class Calc
    {
        #region Atributos
        private string marca;
        private string color;
        private string funciones;
        private int precio;
        private int teclas;
       
        #endregion

        #region Constructor
        public Calc()
        {
            precio = 600;
            funciones = "Calculo, Potencias y Algebra";
            Console.WriteLine("Todas las calculadoras cuestan {0} y tienen funciones de {1}",precio,funciones);

        }

        
        public Calc(string marca, string color)
        {
            this.marca = marca;
            Console.WriteLine("La marca es {0}  y de color {1}", this.marca, this.color);
        }
        public Calc(string funciones, int precio)
        {
            this.funciones = funciones;
            this.precio = precio;
            Console.WriteLine("la versión básica de {0} como funciones y cuesta ${1} pesos",this.funciones, this.precio);

        }
        public Calc(int teclas)
        {
            this.precio = 600;
            this.teclas = teclas;

            Console.WriteLine("La version de {0} teclas extra cuesta ${1} extra", this.teclas, this.precio);
        }
        #endregion
    }
}
