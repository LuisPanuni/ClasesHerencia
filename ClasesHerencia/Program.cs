using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "lpauni";
            estudiante.Password = "12345";
            estudiante.Nombre = "Luis";
            estudiante.Matricula = "45KD3";

            estudiante.login("lpauni", "12345");
            estudiante.login();


            //Listas en ves de Arrays en .net C#
            List<Docente> listaDocentes = new List<Docente>();
            listaDocentes.Add(new Docente() { 
              Cuenta = "smamani",
              Password = "123477",
              Nombre = "Saul",
              Sueldo = 1234
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "sperez",
                Password = "123477",
                Nombre = "Ana",
                Sueldo = 123
            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "scarla",
                Password = "123477",
                Nombre = "Carla",
                Sueldo = 12
            });

            MostrarLista(listaDocentes);

            Double promedio = getPromedio(listaDocentes);
            Console.WriteLine("\n--- Promedio: {0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocentes);
            Console.WriteLine("\n--- Promedio Dos: {0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedioTres(listaDocentes);
            Console.WriteLine("\n--- Promedio Tres: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedioCuatro(listaDocentes);
            Console.WriteLine("\n--- Promedio Cuatro: {0}", promedio4.ToString("##.##"));

            //Listas con 5 estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "sLuz",
                Password = "1233577",
                Nombre = "Luz",
                Matricula = "45KD3",
                Edad = 23
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "sLuis",
                Password = "1357",
                Nombre = "Luiss",
                Matricula = "6K435",
                Edad = 21
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "sMaria",
                Password = "1676",
                Nombre = "Maria",
                Matricula = "K67LE",
                Edad = 20
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "sJuan",
                Password = "67939",
                Nombre = "Juan",
                Matricula = "L64JKE",
                Edad = 25
            });
            listaEstudiantes.Add(new Estudiante()
            {
                Cuenta = "sCarlos",
                Password = "59693",
                Nombre = "Carlos",
                Matricula = "CTK4D4",
                Edad = 19
            });

            MostrarLista1(listaEstudiantes);

            //PROMEDIO DE EDADES 
            Double promedio_Ed = getPromedioEd(listaEstudiantes);
            Console.WriteLine("\n--- Promedio Edad: {0}", promedio_Ed.ToString("##.##"));

            double promedio_Ed2 = getPromedioEdDos(listaEstudiantes);
            Console.WriteLine("\n--- Promedio Edad Dos: {0}", promedio_Ed2.ToString("##.##"));

            double promedio_Ed3 = getPromedioEdTres(listaEstudiantes);
            Console.WriteLine("\n--- Promedio Edad Tres: {0}", promedio_Ed3.ToString("##.##"));

            double promedio_Ed4 = getPromedioEdCuatro(listaEstudiantes);
            Console.WriteLine("\n--- Promedio Edad Cuatro: {0}", promedio_Ed4.ToString("##.##"));


            Console.ReadKey();  
        }
        //PROMEDIO EDAD
        private static double getPromedioEdCuatro(List<Estudiante> listaEstudiantes)
        {
            double prom = (

                from item in listaEstudiantes
                where item.Edad < 25
                select item.Edad
                ).Average();
            return (double)prom;
        }

        private static double getPromedioEdTres(List<Estudiante> listaEstudiantes)
        {
            double sum = listaEstudiantes.Sum(x => x.Edad);
            int total = listaEstudiantes.Count();
            return (double)sum / total;
        }

        private static double getPromedioEdDos(List<Estudiante> listaEstudiantes)
        {
            //Funciones lamda
            double promedio_Ed = listaEstudiantes.Average(x => x.Edad);
            return (double)promedio_Ed;
        }

        private static double getPromedioEd(List<Estudiante> listaEstudiantes)
        {
            double sum = 0;
            foreach (Estudiante item in listaEstudiantes)
            {
                sum += item.Edad;
            }
            return (double)(sum / listaEstudiantes.Count());
        }
        //PROMEDIO DE SUELDO
        private static double getPromedioCuatro(List<Docente> listaDocentes)
        {
            //consultas LINQ
            decimal prom = (

                from item in listaDocentes
                where item.Sueldo < 200
                select item.Sueldo

                ).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocentes)
        {
            decimal sum = listaDocentes.Sum(x => x.Sueldo);
            int total = listaDocentes.Count();
            return (double)sum / total;
        }

        private static double getPromedioDos(List<Docente> listaDocentes)
        {
            //Funciones lamda
            decimal promedio = listaDocentes.Average(x => x.Sueldo);
            return (double)promedio;

        }

        private static double getPromedio(List<Docente> listaDocentes)
        {
            Decimal sum = 0;
            foreach(Docente item in listaDocentes)
            {
                sum += item.Sueldo;
            }
            return (double)(sum / listaDocentes.Count());
        }
        //LISTA DOCENTES
        private static void MostrarLista(List<Docente> listaDocentes)
        {
            Console.WriteLine("\n-------LISTA DE DOCENTES-------\n");
            
            foreach (Docente item in listaDocentes)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //LISTA ESTUDIANTES
        private static void MostrarLista1(List<Estudiante> listaEstudiantes)
        {
            Console.WriteLine("\n-------LISTA DE ESTUDIANTES-------\n");

            foreach (Estudiante item in listaEstudiantes)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }
}
