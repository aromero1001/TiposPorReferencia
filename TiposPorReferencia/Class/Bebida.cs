using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using TiposPorReferencia.Interfaces;

namespace TiposPorReferencia.Class
{

    public delegate void Imprimir<T>(T valor);


    public class Bebida : IBebidaAlcoholica
    {
        private double Precio { get; set; } 
        
        protected int Cantidad { get; set; }
        public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Nombre 
        {
            get => field;

            set
            {
                if (value.Length > 0)
                {
                    field = value;
                }
                else
                {
                    Console.WriteLine("El nombre no puede ser vacío");
                }
            }
        }
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
