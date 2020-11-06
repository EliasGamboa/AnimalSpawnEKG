using System;
using System.Collections.Generic;

namespace AnimalSpawn.Infraestructure.Data
{
    public partial class Usuarios
    {
        public int Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Telefono { get; set; }
        public bool? Estatus { get; set; }
    }
}
