using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace crudEF.Entities
{
    [Table("CLIENTES")]
    class Productos
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Nit { get; set; }

        public string Direccion {get; set;}

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Correo {get; set;}
    }
}
