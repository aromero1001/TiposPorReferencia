using System;
using System.Collections.Generic;
using System.Text;

namespace TiposPorReferencia.Interfaces
{
    interface  IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        void Beberse(int cuantoBebio);
    }
}
