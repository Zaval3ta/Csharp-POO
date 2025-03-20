namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Math suma = new Math();
            Console.WriteLine(suma.Suma(2,2));
            Console.WriteLine(suma.Suma("5","5"));
            int[] numeros = new int[] { 10, 5, 2, 3 };
            Console.WriteLine(suma.Suma(numeros));
        }

    }

    public class Math
    {
        // Sobrecarga de métodos
        //Función que suma dos números enteros
        public int Suma(int a, int b)
        {
            return a + b;
        }
        //Función que suma dos números en formato string
        public int Suma(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        //Función que suma un arreglo de números
        public int Suma(int[] numeros)
        {
            int resultado = 0;
            int i = 0;
            while(i < numeros.Length)
            {
                resultado += numeros[i];
                i++;
            }
            return resultado;
        }
        
    }
}