using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardarAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Que operacion desea realizar?");
                Console.WriteLine("1) Crear nuevo alumno");
                Console.WriteLine("2) Salir");
                Console.WriteLine("3) Configuracion");


                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {

                    Console.WriteLine("Que identificador tiene?");
                    int identificador = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Que nombre tiene?");

                    String nombre = Console.ReadLine();
                    Console.WriteLine("Que apellido tiene?");
                    String apellido = Console.ReadLine();

                    Console.WriteLine("Que DNI tiene?");
                    String dni = Console.ReadLine();

                    Alumno alumno = new Alumno(identificador, nombre, apellido, dni);

                    //File.Create("..\\alumnos.txt");

                    //Console.WriteLine("Exists? " + !File.Exists("..\\alumnos.txt") ) ;

                    StreamWriter file = new StreamWriter("..\\alumnos.txt", true);

                    file.WriteLine("{0}, {1}, {2}, {3}", alumno.GetId(), alumno.GetNombre(), alumno.GetApellid(), alumno.Getdni());
                    file.Close();

                    

                    if (!File.Exists("..\\alumnos.json"))
                    {
                        List<Alumno> alumnos = new List<Alumno>();
                        alumnos.Add(alumno);

                        using (StreamWriter jsonfile = File.CreateText("..\\alumnos.json"))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(jsonfile, alumnos.ToString());
                        }
                    } else
                    {
                        var jsonData = File.ReadAllText("..\\alumnos.json");
                        // De-serialize to object or create new list
                        var alumnoList = JsonConvert.DeserializeObject<List<Alumno>>(jsonData);

                        // Add any new employees
                        alumnoList.Add(alumno);

                        // Update json data string
                        jsonData = JsonConvert.SerializeObject(alumnoList, Formatting.Indented);
                        File.WriteAllText("..\\alumnos.json", jsonData.ToString());
                    }
                   

                }

            } while (opcion != 2);
        }
    }
}
