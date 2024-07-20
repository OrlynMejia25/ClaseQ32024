

namespace ClaseQ32024
{
    public class Ave
    {
        public string Nombre { get; set; }

        public string Color { get; set; }

        public string Tamano { get; set; }

        public string Familia { get; set; }

        public string sexoBiologico { get; set; }

        public bool EsVoladora { get; set; }

        // constructor
        public Ave()
        {
            EsVoladora = true;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Sexo Biologico: {sexoBiologico}");
          //  Console.WriteLine($"Es Voladora: {(EsVoladora ? "si" : "No")}");
            Console.WriteLine();

            if (EsVoladora)
            {
                Console.WriteLine($"Es Voladora: si");
            }
            else
            {
                Console.WriteLine($"Es Voladora: no");
            }
        }
    }
}
