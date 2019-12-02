using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.Models
{
    public class Recepcionista
    {
        [Key]
        [Display(Name="ID")]
        public int ID { get; set; }
        [Display(Name="Nombres")]
        public string Nombres { get; set; }
        [Display(Name="Apellidos")]
        public string Apellidos { get; set; }
        [Display(Name="Dirección")]
        public string Dirección { get; set; }
        [Display(Name="Teléfono")]
        public int Numero { get; set; }   
        public ICollection<Registro> Registros { get; set; }
    }
}