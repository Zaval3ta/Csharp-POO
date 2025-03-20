namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Juan", 34, "Cirujano");
            Console.WriteLine(doctor.GetInfo());
            Console.WriteLine(doctor.GetInfoDoctor());
            // GetInfo() es un metodo de la clase Persona (clase padre)
            Dev dev = new Dev("Cesar", 24, "BackEnd Dev");
            Console.WriteLine(dev.GetInfoDev());
        }

        class Persona
        {
            private string _nombre;
            private int _edad;
            // Constructor
            public Persona(string nombre, int edad)
            {
                _nombre = nombre;
                _edad = edad;
            }
            // Metodo
            public string GetInfo()
            {
                return _nombre + " " + _edad;
            }
        }

        class Doctor : Persona
        {
            private string _especialidad;
            //Constructor heredado de la clase Persona
            public Doctor(string nombre, int edad, string especialidad) : base(nombre, edad)
            {
                _especialidad = especialidad;
            }
            // Metodo de la clase Doctor
            public string GetInfoDoctor()
            {
                return GetInfo() + " " + _especialidad;
                // GetInfo() es un metodo de la clase Persona (clase padre)
            }
        }

        class Dev : Persona
        {
            private string _lenguaje;

            public Dev(string nombre, int edad, string lenguaje) : base(nombre,edad)
            {
                _lenguaje = lenguaje;
            }

            //Metodo de la clase Dev
            public string GetInfoDev()
            {
                return GetInfo() + " " + _lenguaje; // GetInfo() es un metodo de la clase Persona (clase padre)
            }
        }
    }
}