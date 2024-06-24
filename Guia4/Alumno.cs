using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Alumno
    {
        public string Nombre { get; set; }

        public int Edad {  get; set; }

        public string carné { get; set; }

        public Carreras Carreras { get; set; }

        public List<double> Calificaciones { get; set; }


        public Alumno(string nombre, int edad, string carné, Carreras carreras, List<double> calificaciones)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.carné = carné;
            this.Carreras = carreras;
            this.Calificaciones = calificaciones;
        }

        public double CalcularPromedioCalifaciones()
        {
            if(Calificaciones.Count == 0)
            {
                return 0;
            }
            double sumaCalificaciones = 0;
            foreach(var calificaciones in Calificaciones)
            {
                sumaCalificaciones += calificaciones;
            }
            return sumaCalificaciones / Calificaciones.Count;
        }

        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalifaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
