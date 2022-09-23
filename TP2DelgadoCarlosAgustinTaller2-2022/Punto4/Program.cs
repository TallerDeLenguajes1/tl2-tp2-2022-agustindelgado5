using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TP2DelgadoCarlosAgustinTaller2_2022
{
    public enum CursoInscripto { Atletismo=0, Voley=1, Futbol=2 };
    

    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();//inicializo el objeto logger
        static void Main(string[] args)
        {
            Random ran = new Random();
            // int cantidad = 1;




            //Creo 4 listas distintas de tipo alumno
            List<Alumno> ListAlumno = new List<Alumno>();
            List<Alumno> ListAtletismo = new List<Alumno>();
            List<Alumno> ListVoley = new List<Alumno>();
            List<Alumno> ListFutbol = new List<Alumno>();

            Console.WriteLine("Ingresar N Alumnos");
            int N = Convert.ToInt32(Console.ReadLine());

          // Alumno alumno = new Alumno();
            ListAlumno = CargarAlumnos(N);
            
            Console.WriteLine();
            Console.WriteLine("Listado de alumnos que voy cargando");
            Console.WriteLine("----------------------------------------------------------");
         
            //creo los 3 archivos
            Helper.CrearArchivo(@"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Atletismo.csv");
            Helper.CrearArchivo(@"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Voley.csv");
            Helper.CrearArchivo(@"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Futbol.csv");

            for (int i = 0; i < N; i++)
            {
                if (CursoInscripto.Atletismo == ListAlumno[i].cursoInscripto)
                {
                  ListAtletismo.Add(ListAlumno[i]);


                }
                if(CursoInscripto.Voley==ListAlumno[i].cursoInscripto)
                {

                    ListVoley.Add(ListAlumno[i]);
                }
                if(CursoInscripto.Futbol==ListAlumno[i].cursoInscripto)
                {

                    ListFutbol.Add(ListAlumno[i]);
                }

            }

              string archivo1 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Atletismo.csv";
              string archivo2 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Voley.csv";
              string archivo3 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\Punto4\Futbol.csv";
              //ListAlumno.Add(al);
              MostrarAlumnos(ListAlumno);
              //MostrarAlumnos(ListAlumno.ElementAt(ran.Next(0, N));

              Helper.CargandoArchivo(archivo1,ListAtletismo);
              //Helper.EliminarArchivo(archivo1);
              Helper.CargandoArchivo(archivo2,ListVoley);
              //Helper.EliminarArchivo(archivo2);
              Helper.CargandoArchivo(archivo3,ListFutbol);
              //Helper.EliminarArchivo(archivo3);
              Console.ReadKey();
            /*foreach (Alumno al in ListAlumno)
            {
                string archivo1 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\TP2DelgadoCarlosAgustinTaller2-2022\Atletismo.csv";
                string archivo2 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\TP2DelgadoCarlosAgustinTaller2-2022\Voley.csv";
                string archivo3 = @"C:\Users\p\source\repos\TP2DelgadoCarlosAgustinTaller2-2022\TP2DelgadoCarlosAgustinTaller2-2022\Futbol.csv";
                //ListAlumno.Add(al);
                MostrarAlumnos(ListAlumno);
                //MostrarAlumnos(ListAlumno.ElementAt(ran.Next(0, N));
              
                Helper.CargandoArchivo(archivo1,ListAtletismo);
                Helper.EliminarArchivo(archivo1);
                Helper.CargandoArchivo(archivo2,ListVoley);
                Helper.EliminarArchivo(archivo2);
                Helper.CargandoArchivo(archivo3,ListFutbol);
                Helper.EliminarArchivo(archivo3);
                Console.ReadKey();
            }*/



        }

        public static List<Alumno> CargarAlumnos(int N)
        {
            //Alumno[] Alum = new Alumno[N];//defino un arreglo de N Alumnos
            Alumno al=new Alumno();
            List<Alumno> Alumnos = new List<Alumno>();
            try
            {
                for (int i = 0; i < N; i++)
                {

                    Console.WriteLine("Ingrese los datos del alumno");
                    Console.WriteLine("............................");


                    Random rand = new Random();
                    //string[] NombresArreglo = { "Agustín", "Nestor", "Gustavo", "Fabiana", "Antonella"};
                    //string[] ApellidosArreglo = { "Delgado", "Ríos","Andrada", "Soria", "Soto" };
                    Console.Write("ID inscripcion: ");
                    int idAle = rand.Next(0, 123);
                    Console.Write(idAle);
                    Console.WriteLine();
                    //int aleaterio = rand.Next(0, 6);
                    Console.Write("Nombre: ");
                    string NombreAleatorio = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string ApeAleatorio = Console.ReadLine();
                    //string NombreAleatorio = NombresArreglo[aleaterio];
                    //string ApeAleatorio = ApellidosArreglo[aleaterio];
                    int DniAle = rand.Next(0, 12345678);
                    int CursoAle = rand.Next(0, 2);

                    switch (CursoAle)
                    {
                        case 0:
                            Console.WriteLine("Atletismo");
                            break;
                        case 1:
                            Console.WriteLine("Voley");
                            break;
                        case 2:
                            Console.WriteLine("Futbol");
                            break;
                    }
                   
                    CursoInscripto cursoInscriptoAle = (CursoInscripto)CursoAle;
                    Alumnos.Add(new Alumno(idAle, NombreAleatorio, ApeAleatorio, DniAle, CursoAle, cursoInscriptoAle));
                    //Alum[i] = new Alumno(idAle, NombreAleatorio, ApeAleatorio, DniAle, CursoAle, cursoInscriptoAle);
                    //Alumnos.Add(Alum[i]);
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingreso un valor INVALIDO, debe ingresar un numeros ENTERO");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ingreso un valor demasiado GRANDE");
                
            }


            catch (Exception exp)
            {
                Console.WriteLine("\n-------------ALERTA-----------------");
                Console.WriteLine("Error no se pudo cargar los datos " + exp.Message);
                logger.Info(exp.Message);
                logger.Debug(exp.Message);
                logger.Error(exp.Message);
                logger.Fatal(exp.Message);
            }
            return Alumnos;

        }
        public static void MostrarAlumnos(List<Alumno> alumnos)
        {
            foreach (var item in alumnos)
            {
                Console.WriteLine("ID:" + item.Id);
                Console.WriteLine("Nombre:" + item.Nombre);
                Console.WriteLine("Apellido:" + item.Apellido);
                Console.WriteLine("DNI:" + item.Dni);
                Console.WriteLine("Curso:" + item.Curso);
                Console.WriteLine("CursoInsri:" + item.cursoInscripto);
            }
         
          
        }

    }
    
}

