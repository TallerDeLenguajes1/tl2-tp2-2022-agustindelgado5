using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TP2DelgadoCarlosAgustinTaller2_2022
{
    public static class Helper
    {


        public static void CrearArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                using (StreamWriter file = new StreamWriter(File.Open(ruta, FileMode.Create)))
                {
                    file.Close();
                    Console.WriteLine("Creando archivo");
                }
            }
            else
            {
                Console.WriteLine("Ya existe el archivo");
            }
        }
        public static void CargandoArchivo(string ruta, List<Alumno> ListPrincipal)
        {
            using (StreamWriter file = new StreamWriter(File.Open(ruta, FileMode.Append)))
            {
                for (int i = 0; i < ListPrincipal.Count; i++)
                {
                    file.Write(ListPrincipal[i].Id + ";");
                    file.Write(ListPrincipal[i].Nombre + ";");
                    file.Write(ListPrincipal[i].Apellido + ";");
                    file.WriteLine(ListPrincipal[i].Dni + ";");
                    file.WriteLine(ListPrincipal[i].Curso + ";");
                }
                //file.WriteLine("\n");
                file.Close();
                Console.WriteLine("Escribiendo");
            }
        }

        public static void EliminarArchivo(string ruta)
        {
            File.Delete(ruta);
            FileStream Fstream = new FileStream(ruta, FileMode.OpenOrCreate);
            using (StreamWriter StreamW = new StreamWriter(Fstream))
            {
                StreamW.WriteLine("ID,Apellido,Nombre,DNI,Curso");
            }
            Fstream.Close();
        }



    }
}
