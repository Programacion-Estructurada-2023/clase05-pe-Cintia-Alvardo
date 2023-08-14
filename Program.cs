using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaración de Variables

            //Declaración de variable de tipo texto con captura desde consola

            string? universidad = "";

            //Declaración de variables de tipo texto con asignación desde código

            string facultad = "Ingenieria y Arquitectura";
            string profeción = "Ingeniro en Desarrollo de Software";

            //Declaración de variables entera con captura desde consola

            int anioIngreso = 0;

            //Declaración de variables enteras con asignando valores
            int edadIngreso = 18;
            int edadEgreso = 20;

            //Declaración de variable double asignación desde consola

            double countUniversidad = 110.00;

            //Declaración de variable double asignación desde consola
            double gastoTransporte = 35.50;

            /// CAPTURA DE DATOS DESDE CONSOLA

            Console.WriteLine("\n***************************************************************************************");
            Console.WriteLine("\n-----------Captirando datos de tipo texto-----------");
            Console.WriteLine("Ingresa el nombre de la Universidad donde estudia >> ");
            universidad = Convert.ToString( Console.ReadLine());
            Console.WriteLine("\n------Fin de captura de tipo texto------\n");

            Console.WriteLine("\n-----Captuando datos de tipo enteros------\n");
            Console.WriteLine("Ingrese el año en que inicio la Universidad >> ");
            anioIngreso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-------Fin de captura de datos enteros------\n");

            Console.WriteLine("\n-----Captuando datos de tipo decimal------\n");
            Console.WriteLine("Ingrese la cuota de la Universidad >> ");
            countUniversidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n-------Fin de captura de tipo decimal ------\n");
            Console.WriteLine("\n***************************************************************************************\n");

            //IMPRECIÓN DE DATOS EN CONSOLA
            Console.WriteLine("*****************************************************************************************\n\n");
            Console.WriteLine("\n------IMPRECIÓN DE DATOS DE TIPO TEXTO------");
            Console.WriteLine("\n La Univercidad en la que estudia es >> " + universidad);
            Console.WriteLine("\n Pertenece a la facultad de >> " + facultad);
            Console.WriteLine("\n Estudiando la carrera de  >> " + profeción);
            Console.WriteLine("*****************************************************************************************\n");

            Console.WriteLine("*****************************************************************************************\n\n");
            Console.WriteLine("\n------IMPRECIÓN DE DATOS DE TIPO ENTERO------");
            Console.WriteLine("\n El año que ingreso a la Universidad fue >> " + anioIngreso);
            Console.WriteLine("\n La edad que inicio sus estudios es  >> " + edadIngreso + " años");
            Console.WriteLine("\n La edad cuando finalice sus estudios >> " + edadEgreso+ " años");
            Console.WriteLine("*****************************************************************************************\n");

            Console.WriteLine("*****************************************************************************************\n\n");
            Console.WriteLine("\n------IMPRECIÓN DE DATOS DE TIPO DOUBLE------");
            Console.WriteLine("\n La cuota de su univeridad es >> " + "$" + countUniversidad);
            Console.WriteLine("\n Su gasto de transporte es  >> " + gastoTransporte);
            Console.WriteLine("*****************************************************************************************\n");


            Console.ReadKey();
            





        }
    }
}
