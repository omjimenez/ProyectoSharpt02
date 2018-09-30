

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string nombre;

        public string Nombre 
        { 
            get{return "Copia "+nombre;}
            set {nombre = value.ToUpper();} 
            } 

        public int AñoDeCreación { get; set; }
        public TiposEscuela TipoEscuela {get; set;}

  //    public TiposEscuela TipoEscuela { get; set; }

public string Pais { get; set; }
public string Ciudad { get; set; }

public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

public Escuela(string nombre, int año, TiposEscuela tipos, string pais = "", string ciudad ="")
{
     (Nombre, AñoDeCreación) = (nombre, año);
     Pais = pais;
     Ciudad = ciudad;
}

public override string ToString()
{
    return $"Nombre: {Nombre} , Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
}

    }
}