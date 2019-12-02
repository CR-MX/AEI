using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.Models
{
    public class Receta
    {
        [Key]
        [Display(Name="ID")]
        public int ID { get; set; }
        [Display(Name="Fecha")]
        public DateTime Fecha { get; set; }
        [Display(Name="Receta/Descripción")]
        public String  Descripcion { get; set; }
    }
}