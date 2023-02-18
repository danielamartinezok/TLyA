using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_02
{
    class Cliente
    {
        private string nombre;
        private string telefono;

        public Cliente(string n, string t)
        {
            this.nombre = n;
            this.telefono = t;
        }

        public override string ToString()
        {
            return (nombre + "" + telefono);
        }

        public override bool Equals(object otroCliente)
        {
            bool retorno = false;

            if (otroCliente != null)
            {
                if (otroCliente is Cliente)
                {
                    Cliente compararCliente = otroCliente as Cliente;

                    if (compararCliente.nombre == this.nombre)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}
