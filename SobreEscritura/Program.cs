namespace SobreEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(); //instanciamos un objeto de la clase B
            Console.WriteLine(b.Hi());

            //Clase venta
            Venta venta = new Venta(10);
            venta.Agregar(10);
            venta.Agregar(20);
            Console.WriteLine(venta.GetTotal());

            //Clase venta con iva
            VentaIva ventaiva = new VentaIva(10, 1.16m); //m para indicar que es decimal
            ventaiva.Agregar(10);
            ventaiva.Agregar(20);
            Console.WriteLine(ventaiva.GetTotal()); //imprime el total con iva
        }
    }
    //Clase Venta
    public class Venta
    {
        private decimal[] _montos;
        private int _n;
        private int _final;

        public Venta(int n)
        {
            _montos = new decimal[n];
            _n = n;
            _final = 0;
        }
        public void Agregar(decimal monto)
        {
            if (_final < _n)
            {
                _montos[_final] = monto;
                _final++;
            }
        }
        public virtual decimal GetTotal()
        {
            decimal total = 0;
            for (int i = 0; i < _montos.Length; i++)
            {
                total += _montos[i];
            }
            return total;
        }


    }

    //Clase Venta con iva
    public class  VentaIva : Venta
    {
        private decimal _iva;
        public VentaIva(int n, decimal iva) : base(n)
        {
            _iva = iva;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _iva; //base.GetTotal() llama al metodo GetTotal() de la clase base (Venta)
            
        }
    }

    public class A
    {  public virtual string Hi() //virtual permite que el metodo sea sobreescrito
        {
            return "Hola soy A";
        }
    }

    public class B : A
    {
        //sobreescritura del metodo Hi()
        public override string Hi() //override permite que el metodo sea sobreescrito
        {
            return base.Hi() + " " + "Hola soy B"; //base.Hi() llama al metodo Hi() de la clase base (A)
        }
    }
}