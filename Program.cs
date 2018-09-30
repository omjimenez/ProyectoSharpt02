using System;
using CoreEscuela.Entidades;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academi", 2012,TiposEscuela.PreEscolar,pais:"Panama", ciudad:"Colón");
            escuela.Pais = "Panama";
            escuela.Ciudad = "Colon";
            escuela.TipoEscuela = TiposEscuela.PreEscolar;
           
           Curso curso1 = new Curso(){
               Nombre = "101"
           };

           Curso curso2 = new Curso(){
               Nombre = "201"
           };

           Curso curso3 = new Curso(){
               Nombre = "301"
           };


           // Console.WriteLine(escuela.Nombre);
           System.Console.WriteLine(escuela);

           System.Console.WriteLine("===================");
           Console.WriteLine(curso1.Nombre + " ,"+curso1.UniqueId);
           Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
           Console.WriteLine(curso3);
           
        }
    }
}
