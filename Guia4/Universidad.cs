using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Universidad
    {
        private List<Alumno> listaAlumno;

        public Universidad()
        {
            listaAlumno = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumno.Add(alumno);
        }

        public List<Alumno> ObtenerListaAlumno()
        {
            return listaAlumno;
        }
    }
}
