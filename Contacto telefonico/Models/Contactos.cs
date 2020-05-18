using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacto_telefonico.Models
{
    public class Contactos
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Compania { get; set; }
        public String Titulo { get; set; }
        public String Telefono { get; set; }
        public String CorreoElectronico{ get; set; }
    }
}