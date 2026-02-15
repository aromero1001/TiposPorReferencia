using System;
using System.Collections.Generic;
using System.Text;

namespace TiposPorReferencia.Class
{
    public class Cerveza : Bebida
    {
        public string Marca { get; set; }

        public Cerveza(string nombre, int cantidad, double precio, string marca="Pepsi" ) : base(nombre, cantidad, precio)
        {
            this.Marca = marca;
        }

        public int Servir(int cuantoSirvio)
        {
            if (cuantoSirvio > this.Cantidad)
            {
                Console.WriteLine("No hay suficiente cerveza para servir esa cantidad.");
                return 0;
            }
            else
            {
                this.Cantidad -= cuantoSirvio;
                Console.WriteLine($"Se sirvieron {cuantoSirvio} unidades de cerveza. Quedan {this.Cantidad} unidades.");
                return cuantoSirvio;
            }
        }
    }
}
