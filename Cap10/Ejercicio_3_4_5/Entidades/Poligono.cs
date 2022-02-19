using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap10.Entidades
{
    public class Poligono
    {
        public int L1 { get; set; }
        public int L2 { get; set; }
        public int L3 { get; set; }
        public int L4 { get; set; }

        public Poligono(int L1, int L2, int L3, int L4)
        {

        }

        public Poligono(int L1, int L2, int L3)
        {
            this.L1 = L1;
            this.L2 = L2;
            this.L3 = L3;
        }

        public String Validar(int l1, int l2, int l3)
        {
            if(l1 <= 0)
            {
                return "El lado 1 no puede ser menor o igual a 0";
            }
            if (l2 <= 0)
            {
                return "El lado 2 no puede ser menor o igual a 0";
            }
            if (l3 <= 0)
            {
                return "El lado 3 no puede ser menor o igual a 0";
            }
            return "";
        }

        public override string ToString()
        {
            int calculo = L1 + L2 + L3;

            return calculo.ToString();
        }
        
    }
}