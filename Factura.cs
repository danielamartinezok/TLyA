using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_02
{
    class Factura
    {
        private string cliente;
        private double importe;
        private long numero;

        public Factura(string c, double i, long n)
        {
            this.cliente = c;
            this.importe = i;
            this.numero = n;
        }

        public override bool Equals(object otraFactura)
        {
            bool retorno = false;

            if (otraFactura != null)
            {
                if (otraFactura is Factura)
                {
                    Factura compararFactura = otraFactura as Factura;

                    if (compararFactura.numero == this.numero)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public double getImporte()
        {
            return importe;
        }
    }
}