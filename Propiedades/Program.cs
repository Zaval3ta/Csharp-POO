namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(100, DateTime.Now);
            sale.Total = 200;
            Console.WriteLine(sale.Total);
        }
    }

    class Sale
    {
        //Atributos de la clase
        int total;
        DateTime date; //DateTime es una clase de C# que representa una fecha y hora
        //Pueden haber mas clases dentro de una clase

        //Propiedades de la clase
        //Get solo se usa para obtener el valor de la propiedad. No se puede modificar el valor de la propiedad
        //Set se usa para asignar un valor a la propiedad. Se puede modificar el valor de la propiedad
        public int Total
        {
            get { return total; } //get es el metodo que se ejecuta cuando se lee la propiedad
            //get obtiene el valor de la propiedad
            set
            { //value es una palabra reservada que se usa para asignar un valor a la propiedad, por defecto es de tipo object
                if (value < 0)
                    value = 0;
                total = value;
            } 
            //set es el metodo que se ejecuta cuando se asigna un valor a la propiedad
            //set asigna un valor a la propiedad. Y tambien se puede usar para validar el valor que se le asigna
            //set nos permite controlar el acceso a la propiedad y nos permite editar el valor que se le asigna
        }

        //Constructor de la clase
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        
    }
}