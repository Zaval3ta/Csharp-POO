namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now); //Creacion de un objeto de la clase Sale
            //.Now es una propiedad de la clase DateTime que devuelve la fecha y hora actual
            sale1.Show(); //Llamada al metodo Show de la clase Sale
            Console.WriteLine(sale1.GetInfo()); //Llamada al metodo GetInfo de la clase Sale
        }
    }

    class Sale 
    {
        //Atributos de la clase
        int total;
        DateTime date; //DateTime es una clase de C# que representa una fecha y hora
        //Pueden haber mas clases dentro de una clase

        //Constructor de la clase
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        //Metodo para mostrar la info de la clase
        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }

        //Metodo de la clase
        public void Show()
        {
            Console.WriteLine("Soy una venta");
        }
    }
}