namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui se crea un arreglo de la clase Tiburon
            //Sea agrega nombre y velocidad a cada objeto. cumple con la interfaz IAnimal e IPez
            //Se cumple con la interfaz IAnimal y IPez. Ya que se implementa el metodo Nombre de la interfaz IAnimal y velocidad de la interfaz IPez
            Tiburon[] tiburon = new Tiburon[]
            {
                new Tiburon("Tiburon Blanco", 58),
                new Tiburon("Tiburon Martillo", 45),
                new Tiburon("Tiburon Toro", 50)
            };
            ShowPescado(tiburon); //Aqui se llama al metodo ShowPescado y se le pasa el arreglo de la clase Tiburon
            ShowAnimal(tiburon); //Aqui se llama al metodo ShowAnimal y se le pasa el arreglo de la clase Tiburon

            //Esto es una capsula. Se crea un arreglo de la interfaz IPez
            IPez[] pescados = new IPez[] //Aqui se crea un arreglo de la interfaz IPez
            //Se cumple con la interfaz IPez ya que se implementa el metodo Nadar
            //Este arreglo contiene objetos de la clase Sirena y Tiburon
            {
                //Se crea un arreglo de la clase Sirena
                //Las interfaces se implementan en la clase Sirena
                //Las interfaces no sirven para hacer objetos, pero si para implementarlas en una clase
               new Sirena(30), 
               new Sirena(40),
               new Tiburon("Tiburon Negro", 150)
            };
            ShowPescado(pescados);
        }

        //Metodo que trabaja con la interfaz IPez
        //Aqui implemento la interfaz IPez. Se utiliza el metodo Nadar de la interfaz IPez
        //Se cumple con la interfaz IPez ya que se implementa el metodo Nadar
        public static void ShowPescado(IPez[] pescados)
        {
            Console.WriteLine("Clase tiburon usando la interfaz IAnimal y IPez");

            for (int i = 0; i < pescados.Length; i++)
            {
                Console.WriteLine(pescados[i].Nadar()); //Aqui se llama al metodo Nadar de la interfaz IPez
            }
        }

        //Metodo que trabaja con la interfaz IAnimal
        //Aqui implemento la interfaz IAnimal. Se utiliza el metodo Nombre de la interfaz IAnimal
        //Se cumple con la interfaz IAnimal ya que se implementa el metodo Nombre
        public static void ShowAnimal(IAnimal[] animales)
        {
            Console.WriteLine("-----------Interfaz animal------------");
            for(int i = 0; i <animales.Length; i++)
            {
                Console.WriteLine(animales[i].Nombre); //Aqui se llama al metodo Nombre de la interfaz IAnimal
            }
        }

    } //Fin de la clase Program

    //Clase Sirena que implementa la interfaz IPez
    public class Sirena : IPez
    {
        public int Velocidad { get; set; }
        //Constructor de la clase Sirena
        public Sirena(int Velocidad)
        {
            this.Velocidad = Velocidad;
        }
        public string Nadar()
        {
            return $"La sirena nada a una velocidad de {Velocidad}";
        }
    }

    //Clase Tiburon que implementa las interfaces IAnimal e IPez
    public class  Tiburon : IAnimal, IPez 
    {
        public string Nombre { get; set; }
        public int Velocidad { get; set; }

        //Constructor de la clase
        public Tiburon(string Nombre, int Velocidad)
        {
            this.Nombre = Nombre;
            this.Velocidad = Velocidad;
        }
        //Metodo de la interfaz IPez. Aqui se implementa el metodo
        public string Nadar()
        {
            return $"{Nombre} esta nadando a una velocidad de {Velocidad}";
        }
    }

    //Interfaces
    //Obligo a la clase que implemente la interfaz a tener un nombre
    public interface IAnimal
    {
        public string Nombre { get; set; }
    }

    //Obligo a la clase que implemente la interfaz a tener una velocidad y el metodo Nadar
    public interface IPez
    {
        public int Velocidad { get; set; }

        public string Nadar(); //Metodo. Solo se marca el metodo, pero no se implementa
    }

}