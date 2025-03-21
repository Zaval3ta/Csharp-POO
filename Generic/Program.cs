namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de enteros
            MyList<int> numeros = new MyList<int>(10); //Con Generic se puede definir el tipo de dato en tiempo de ejecución
            numeros.Add(10);
            numeros.Add(20);
            //Crear una lista de cadenas
            MyList<string> cadenas = new MyList<string>(5);
            cadenas.Add("Hola");

            //Mostrar los elementos de la lista de enteros
            Console.WriteLine(numeros.GetElemento(0));
            //Mostrar los elementos de la lista de cadenas
            Console.WriteLine(cadenas.GetElemento(0));

            //Usar el método GetString
            Console.WriteLine(numeros.GetString());
            Console.WriteLine(cadenas.GetString());

            //MyLsit También puede ser de tipo Persona y utilizar el método GetString
            MyList<Persona> personas = new MyList<Persona>(5); //Iniciamos el constructor de MyList
            //Mandamos el limite de elemto que puede tener MyList -> new MyList<Persona>(5)
            personas.Add(new Persona { nombre = "Juan", pais = "Mexico" });
            personas.Add(new Persona { nombre = "Pedro", pais = "España" });
            //Creamos dos objetos de tipo Persona y los añadimos a la lista con el método Add de MyList
            //Usamos el elemento GetString para mostrar los elementos de la lista. Metodo de MyList
            Console.WriteLine(personas.GetString());

        } // Fin del método Main


    } // Fin de la clase Program

    //Clase Persona
    public class Persona // Clase Persona hereda de Object por defecto. 
                         //  Object es la clase base de todas las clases en C#
                         // public class Persona : Object
    {
        public string nombre { get; set; }
        public string pais { get; set; }

        //Sobreescribimos el método ToString para mostrar los elementos de la lista
        public override string ToString() //Sobreescribimos el método ToString de la clase Object
        //ToString por defecto devuelve el nombre de la clase --> Generic.Persona
        {
            return $"Nombre: {nombre}, Pais {pais}"; //Devuelve el nombre y el país de la persona
        }
    }


    //Clase genérica. T es un tipo genérico
    //Generic sirve para reutilizar código y hacerlo más flexible
    //Generic es un tipo de dato que se define en tiempo de ejecución
    public class MyList<T>
    {
        private T[] _elementos; //Generic se utiliza para elementos internos
        private int _index = 0;
        //Constructor
        public MyList(int n)
        {
            _elementos = new T[n];
        }
        //Método para añadir un elemento
        public void Add(T e) //Generic se utiliza para parámetros de métodos(recibir)
        {
            //_index = 0
            if(_index < _elementos.Length) 
            {
                _elementos[_index] = e; //Añadir el elemento
                _index++;
            }
        }
        //Método para mostrar los elementos
        //Generic se utiliza para devolver un tipo de dato
        public T GetElemento(int i)
        {
            if(i <= _index && i >= 0)
            {
                return _elementos[i];
            }
            return default(T); //Valor por defecto. 0 para enteros, null para cadenas
            //De esta manera protegemos el metodo de errores
        }

        public string GetString()
        {
            int i = 0;
            string resultado = "";
            while (i < _index)
            {
                resultado += _elementos[i].ToString() + " | ";
                i++;
            }
            return resultado;
        }

    }
}