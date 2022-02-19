using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap10.Entidades
{
    public class Escuela
    {
         public int Matricula { get; set; }
        public string Nombres { get; set; }
        public string Fecha  { get; set; }
        public string Telefono  { get; set; }
        public string Grado_Curso { get; set; }
        public string Direccion{ get; set; }


        public Escuela(int matricula, string nombres, string fecha, string tel, string grado, string dir )
        {
            this.Matricula = matricula;
            this.Nombres = nombres;
            this.Fecha=fecha;
            this.Telefono = tel;
            this.Grado_Curso = grado;
            this.Direccion = dir;
        }
        
    }
}