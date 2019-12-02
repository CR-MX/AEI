using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.Models
{
    public class Doctor
    {
        [Key]
        [Display(Name="ID")]
        public int ID { get; set; }
        [Display(Name="Nombres")]
        public string Nombres { get; set; }
        [Display(Name="Apellidos")]
        public string Apellidos { get; set; }
        [Display(Name="Cedula")]
        public string Cedula { get; set; }
        [Display(Name="Dirección")]
        public string Dirección { get; set; }
        [Display(Name="Teléfono")]
        public int Numero { get; set; }
        [Display(Name="Turno")]
        public String Turno { get; set; }
        [Display(Name="Disponibilidad")]
        public String Disponibilidad { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }
}