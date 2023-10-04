using System;
using System.Linq;

namespace ConsoleApp_12E_2023C2_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante[] misEstudiantes =
            {
                new Estudiante() {ID = 1, Nombre = "Ariel", Edad = 18},
                new Estudiante() {ID = 2, Nombre = "Marcela", Edad = 14},
                new Estudiante() {ID = 3, Nombre = "Alejandra", Edad = 27},
                new Estudiante() {ID = 4, Nombre = "Hugo", Edad = 17},
                new Estudiante() {ID = 5, Nombre = "Carla", Edad = 21},
                new Estudiante() {ID = 6, Nombre = "Ruben", Edad = 16},
                new Estudiante() {ID = 1, Nombre = "Mariana", Edad = 26},
                new Estudiante() {ID = 1, Nombre = "Edit", Edad = 31},
            };

            // Seleccion de alumnos por edad
            Estudiante[] estuSalida = new Estudiante[8];
            int x = 0;
            foreach (var unEstu in misEstudiantes)
            {
                if (unEstu.Edad > 12 && unEstu.Edad < 21)
                {
                    estuSalida[x] = unEstu;
                    x++;
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(estuSalida[i].Nombre.ToString() + " " + estuSalida[i].Edad);
            }


            Console.WriteLine("Consultando alumnos adolescentes con una expresion de consulta con LinQ");


            // Expresion de Consulta
            var miConsultaLinQEC = from estu in misEstudiantes where estu.Edad > 12 && estu.Edad < 21 orderby estu.Nombre select estu;

            foreach (Estudiante item in miConsultaLinQEC)
            {
                Console.WriteLine(item.Nombre.ToString() + " " + item.Edad);
            }


            Console.WriteLine("Consultando alumnos adolescentes con una expresion lambda");

            // Expresiones Lambda
            Estudiante[] miConsultaLinQLambda = misEstudiantes.Where(estudian => estudian.Edad > 12 && estudian.Edad < 21).ToArray();
            foreach (var item in miConsultaLinQLambda)
            {
                Console.WriteLine(item.Nombre.ToString() + " " + item.Edad);
            }


            Console.WriteLine("Consultando alumnos cuyo nombre contenga una letra L");
            var miConsultaLinQECChar = from estu in misEstudiantes where estu.Nombre.Contains("n") select estu;
            foreach (var item in miConsultaLinQECChar)
            {
                Console.WriteLine(item.Nombre.ToString() + " " + item.Edad);
            }


            Console.WriteLine("Consultando alumnos cuyo nombre contenga una letra L");
            var miConsultaLinQECChar2 = misEstudiantes.Where( es => es.Nombre.Contains('n'));
            foreach (var item in miConsultaLinQECChar2)
            {
                Console.WriteLine(item.Nombre.ToString() + " " + item.Edad);
            }

            Console.ReadKey();
        }
    }
}
