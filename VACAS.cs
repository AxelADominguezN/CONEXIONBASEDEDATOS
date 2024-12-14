using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXIONBASEDEDATOS
{
    public class VacasID
    {
        public int IDVACA { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Estado { get; set; }

        public VacasID() { }
        public VacasID(int id, string Nombre, string Raza, string Estado) 
        {
            this.IDVACA = id;
            this.Nombre = Nombre;
            this.Raza = Raza;
            this.Estado = Estado;
        }
    }
}
