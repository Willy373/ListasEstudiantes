using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> listEstudiante = new List<Estudiante>();
            listEstudiante.Add(new Estudiante()
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Edad = 12,
                Genero = 'M',
                Grado = "CUARTO",
                FechaIngreso = Convert.ToDateTime("02/03/2000")

            });
            listEstudiante.Add(new Estudiante()
            {
                Nombre = "Julio",
                Apellido = "Apaza",
                Edad = 12,
                Genero = 'M',
                Grado = "CUARTO",
                FechaIngreso = Convert.ToDateTime("02/03/2000")

            });

            listEstudiante.Add(new Estudiante()
            {
                Nombre = "Emmy",
                Apellido = "Flores",
                Edad = 16,
                Genero = 'F',
                Grado = "SEXTO",
                FechaIngreso = Convert.ToDateTime("02/03/2000")

            });

            listEstudiante.Add(new Estudiante()
            {
                Nombre = "Sergio",
                Apellido = "Alvarez",
                Edad = 15,
                Genero = 'M',
                Grado = "SEXTO",
                FechaIngreso = Convert.ToDateTime("02/03/2000")

            });
            Console.WriteLine("------------LISTA DE ESTUDIANTES---------------");
            foreach (var est in listEstudiante)
            {
                Console.WriteLine(est.Nombre+ " " + est.Apellido);
            }


            Console.ReadKey();
        }
    }
}
