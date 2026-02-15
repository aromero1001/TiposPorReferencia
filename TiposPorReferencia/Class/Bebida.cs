using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace TiposPorReferencia.Class
{

    public delegate void Imprimir<T>(T valor);


    public class Bebida
    {

        public string Nombre { get; set; }
        private double Precio { get; set; } 
        
        protected int Cantidad { get; set; }

        public void ImprimirPantalla(string v) 
        {
            Console.WriteLine(v);
        }
        public void ImprimirPantallaEntero(int v)
        {
            Console.WriteLine(v.ToString());
        }

        public void EjemploDelegado()
        {
            Imprimir<string> imprimirDel = new Imprimir<string>(ImprimirPantalla);
            imprimirDel("Delegado Bebida");

            Imprimir<int> imprimirDelInt = new Imprimir<int>(ImprimirPantallaEntero);
            imprimirDelInt(100);
        }

        public void Beberse(int cuantoBebio)
        {
            this.Cantidad = cuantoBebio;
        }

        public void EjemploAction()
        { 
            Action<string> imprimirAction = ImprimirPantalla;

        }

        //public void EjemploMetodoAnonimo() 
        //{ 
        //   Action<string> actionEjemploAnonimo = delegate (string v) 
        //   {
        //       Console.WriteLine(v);
        //   };

        //   actionEjemploAnonimo("Ejemplo método anónimo");
        //}

        public void EjemploMetodoAnonimoLambda()
        {
            Action<string> actionEjemploAnonimo = delegate (string v)
            {
                Console.WriteLine(v);
            };

            actionEjemploAnonimo("Ejemplo método anónimo");

            Action<string> actionEjemploLambda = (v) => Console.WriteLine(v);

            actionEjemploLambda("valor a imprimir");
        }

        public void EjemploFunc() 
        {
            Func<int,string> delegadoFunc1 = v=> $"El valor es {v}";

            delegadoFunc1(10);

        }

        public Bebida(string nombre,int cantidad,double precio) 
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }


    public class Imprimir
    {
        public void ClaseAlternativa(Action<string> action)
        {
            action("Imprimir action");
        }
    }
}
