namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persona.Mensaje());
            // Output: Mensaje utilizando static
            // El metodo al ser static no es necesario instanciar la clase para poder acceder a el
            // la clase persona puede ser accedida directamente por ser un metodo static

            Console.WriteLine(Persona2.Mensaje());
            // Output: Al ser una clase static, propiedades, atributos y metodos llevan static y se invocan con la clase sin necesidad de un objeto
            // La clase Persona2 es una clase static, por lo que no es necesario instanciar la clase para poder acceder a el
            // la clase Persona2 puede ser accedida directamente por ser un metodo static
        }
    }

    public class Persona
    {
        //Metodo con static. Es global a la clase y se puede acceder sin instanciar la clase
        //La pertenencia de static es a la clase, no al objeto. Y es unica a la clase
        public static string Mensaje()
        {
            return "Mensaje utilizando static";
        }
    }

    //Clase con static
    //Todo dentro de la clase debe de ser static
    public static class Persona2
    {
        //Metodo con static. No es necesario instanciar la clase para poder acceder a el
        public static string Mensaje()
        {
            return "Al ser una clase static, propiedades, atributos y metodos llevan static y se invocan con la clase sin necesidad de un objeto";
        }
    }
}