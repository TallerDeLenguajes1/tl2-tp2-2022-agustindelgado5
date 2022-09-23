using System;
using System.Collections.Generic;
using System.Text;

namespace TP2DelgadoCarlosAgustinTaller2_2022
{
    public class Alumno
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Dni { get; set; }

        public int Curso { get; set; }

        public CursoInscripto cursoInscripto { get; set; }

        public Alumno(int _Id, string _Nombre, string _Apellido, int _Dni, int _Curso, CursoInscripto _CursoInscripto)
        {
            this.Id = _Id;
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Dni = _Dni;
            this.Curso = _Curso;
            this.cursoInscripto = _CursoInscripto;
        }
        public Alumno()
        {

        }

    }

}
