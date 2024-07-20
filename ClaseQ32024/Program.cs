
using ClaseQ32024;
// Instanciar la clase o declarar un nuevo objeto
Ave ave = new Ave();
ave.Nombre = "Pajaro";
ave.Color = "Varios";
ave.Tamano = "Pequeño";
ave.FamiliaAve.Nombre = "Familia de pajaros";
ave.FamiliaAve.Grupo = "Voladores";
ave.sexoBiologico = "Macho";
ave.Imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Pajaro carpintero";
ave2.Color = "Rojo";
ave2.Tamano = "Mediano";
ave2.FamiliaAve.Nombre = "Familia de pajaros carpinteros";
ave2.FamiliaAve.Grupo = "Carpinteros";
ave2.sexoBiologico = "Hembra";
ave2.EsVoladora = false;
ave2.Imprimir();

