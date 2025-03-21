using System.Text.Json; //Paquete para trabajar con JSON

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza miCerveza = new Cerveza()
            {
                Nombre = "Victoria",
                Marca = "Corona"
            };

            //string json = "{ \"Nombre\": \"Victoria\", \"Marca\": \"Corona\" }";
            //Se le conoce serelización a la conversión de un objeto a un formato JSON
            string json = JsonSerializer.Serialize(miCerveza); //Serialización de un objeto a JSON
            
            //Se le conoce deserialización a la conversión de un formato JSON a un objeto
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(json); //Deserialización de un JSON a un objeto
            
            
            Cerveza[] cervezas = new Cerveza[]
            {
                new Cerveza()
                {
                    Nombre = "Modelo Especial",
                    Marca = "Grupo modelo"
                },
                new Cerveza()
                {
                    Nombre = "Indio",
                    Marca = "Cuauhtémoc Moctezuma"
                }
            };
            string json2 = JsonSerializer.Serialize(cervezas); //Para mandar informacion a otra aplicacion
            Cerveza[] cervezas2 = JsonSerializer.Deserialize<Cerveza[]>(json2);

            /* string json2 = "[ " +
                 "{ \"Nombre\": \"Modelo Especial\", \"Marca\": \"Grupo modelo\" }, " +
                 "{ \"Nombre\": \"Indio\", \"Marca\": \"Cuauhtémoc Moctezuma\" } ]";
            */
            //Json sirve para comunicar aplicaciones
            //Json sirve para comunicar otros medios de comunicación

        } //Fin del método Main

        public class Cerveza
        {
            public string Nombre { get; set; }
            public string Marca { get; set; }
        } //Fin de la clase Cerveza

    }//Fin de la clase Program

} //Fin del namespace JSON