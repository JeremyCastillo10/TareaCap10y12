using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap10.Entidades
{
    public class Tienda
    {
         public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public float Existencia { get; set; }
        public float Costo { get; set; }

        public Tienda(int codigo, string descripcion, int existencia, float costo)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Existencia = existencia;
            this.Costo = costo;
        }
        
    }
}