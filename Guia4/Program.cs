
using Guia4;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Universidad
        Universidad universidad = new Universidad();

        universidad.AgregarAlumno( new Alumno("Juan", 20, "2019-1234", Carreras.Ingenieria_de_Sistemas, new List<double> { 90, 80, 70 }));
        universidad.AgregarAlumno( new Alumno("Maria", 21, "2019-5678", Carreras.Ingenieria_en_computacion, new List<double> { 60, 70, 80 }));
        universidad.AgregarAlumno( new Alumno("Pedro", 22, "2019-9012", Carreras.Telecomunicaciones, new List<double> { 50, 60, 70 }));

        List<Alumno> listaAlumno = universidad.ObtenerListaAlumno();
        universidad.ObtenerListaAlumno().ForEach(alumno => {
            Console.WriteLine($"Nombre: {alumno.Nombre}");
            Console.WriteLine($"Edad: {alumno.Edad}");
            Console.WriteLine($"Carné: {alumno.carné}");
            Console.WriteLine($"Carrera: {alumno.Carreras}");
            Console.WriteLine($"Calificaciones: {string.Join(", ", alumno.Calificaciones)}");
            Console.WriteLine($"Promedio: {alumno.CalcularPromedioCalifaciones()}");
            Console.WriteLine($"Estado: {alumno.EstadoAprobacion()}");
            Console.WriteLine();
        });
    }
}
