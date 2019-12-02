using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.Models
{
    public class Registro
    {
        [Key]
        [Display(Name="ID")]
        public int RegistrosID { get; set; }
        
        public int DoctorID { get; set; }
        public int PacienteID { get; set; }
        public int RecepcionistaID { get; set; }
        [Display(Name="Fecha")]
        public DateTime Fecha { get; set; }
        [Display(Name="Detalles")]
        public String  Detalles { get; set; }
        public ICollection<Receta> Recetas { get; set; }
    }
}
