using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_02
{
    class App
    {
        private Cliente[] clientes;
        private Factura[] facturas;

        public App() 
        {
            clientes = new Cliente[100];
            facturas= new Factura[1000];
        }

        public void ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = pedirStringNoVacio("Menú:\nA - Ingresar cliente\nB - Ingresar Factura\nListar facturas\nD - Estadísticas\nE - Salir");

                if (opcion.Equals("A"))
                {
                    altaDeClientes();
                }
                else if (opcion.Equals("B"))
                {
                    altaDeFacturas();
                }
                else if (opcion.Equals("C"))
                {
                    listarFacturas();
                }
                else if (opcion.Equals("D"))
                {
                    mostrarEstadisticas();
                }

            } while (opcion != "E");
        }
    }
}
