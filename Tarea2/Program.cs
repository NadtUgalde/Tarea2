using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        public static float[] notas = new float[3];
        public static string[] estudiantes = new string[3];
        static void Main(string[] args)  
        {
            menu();
        }

        private static void menu()
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("+***************Menu***************+");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|\tA-Ingresar notas          |");
                Console.WriteLine("|\tB-Consultar notas         |");
                Console.WriteLine("|\tC-Modificar notas         |");
                Console.WriteLine("|\tD-Eliminar registro       |");
                Console.WriteLine("|\tE-Reporte                 |");
                Console.WriteLine("|\tF-Salir                   |");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("+**********************************+");
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("\nDigite una opcion: ");
                 op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "A": Ingresarnotas(); break;
                    case "B": Consulta(); break;
                    case "C": Modificar(); break;
                    case "D": Eliminar(); break;
                    case "E": Reporte(); break;
                    case "F": break;
                    default:
                        Console.WriteLine("Opcion invalida, intente de nuevo.");
                        break;
                }
            } while (!op.Equals("E"));
        }

        public static void Ingresarnotas()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("\nDigite el nombre: ");
                estudiantes[i] = Console.ReadLine().ToLower();
                Console.Write("Digite la nota: ");
                notas[i] = float.Parse(Console.ReadLine());
            }
        }

        public static void Consulta()
        {
       
            String nombEstudiante = "";
            Boolean Existe = false;
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(estudiantes[j] );
            }
            Console.WriteLine("Digite el nombre del estudiante a consultar: ");
            nombEstudiante = Console.ReadLine().ToLower();


            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {

                    Console.WriteLine("La nota del estudiante es: " + notas[i]);
                    Existe = true;
                    break;
                }

            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe, digite de nuevo el nombre.");
            }

             Console.Read();

            
        }

        public static void Modificar()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine(estudiantes[j]);
            }
            Console.WriteLine("Digite el nombre del estudiante a modificar: ");
            nombEstudiante = Console.ReadLine().ToLower();

            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    Console.Write("Actualice el nombre: ");
                    estudiantes[i] = Console.ReadLine();
                    Console.Write("Actualice la nota: ");
                    notas[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe, digite de nuevo el nombre.");
            }
        }
        public static void Eliminar()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine(estudiantes[j]);
            }
            Console.WriteLine("Digite el nombre del estudiante a eliminar: ");
            nombEstudiante = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    estudiantes[i] = "";
                    notas[i] = 0;
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe");
            }
        }
        public static void Reporte()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********** Reporte de Estudiantes **********\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"| Nombre: {estudiantes[i]} | Nota: {notas[i]}           |");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n************* Fin del reporte *************");
            Console.ReadLine();
        }

       
    }
}
