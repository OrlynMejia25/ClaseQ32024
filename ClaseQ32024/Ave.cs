

namespace ClaseQ32024
{
    public class Ave
    {
        public string Nombre { get; set; }

        public string Color { get; set; }

        public string Tamano { get; set; }

        public  FamiliaAve  FamiliaAve { get; set; }

        public string sexoBiologico { get; set; }

        public bool EsVoladora { get; set; }

        // constructor
        public Ave()
        {
            EsVoladora = true;
            FamiliaAve = new FamiliaAve();

        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {FamiliaAve.Nombre}");
            Console.WriteLine($"Grupo: {FamiliaAve.Grupo}");
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
