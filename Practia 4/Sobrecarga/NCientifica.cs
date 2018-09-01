

using System;
using System.IO;

namespace Sobrecarga
{
    class NCientifica
    {
        private int coeficiente;
        private int exponente;

        public NCientifica (int coeficiente, int exponente)
        {
            this.coeficiente = coeficiente;
            this.exponente = exponente;
        }
        
        public static NCientifica operator *(NCientifica n1, NCientifica n2)
        {
            NCientifica n3 = new NCientifica(n1.coeficiente * n2.coeficiente, n1.exponente+n2.exponente);
            return n3;
        }
        public static NCientifica operator ^(NCientifica n1, byte n2)
        {
            NCientifica n = new NCientifica(Convert.ToInt32(Math.Pow(n1.coeficiente, n2)),n1.exponente*n2);
            return n;
        }


        public override string ToString()
        {
            return String.Format("{0}E{1}",coeficiente,exponente);
        }
        
    }
}
