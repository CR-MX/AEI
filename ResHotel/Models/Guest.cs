using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ResHotel.Models
{
    public class Guest
    {
        [Key]
        [Display(Name="ID")]
        public int GuestID { get; set; }
        public string GuestTitle { get; set; }
        [Display(Name="Nombre")]
        [Required(ErrorMessage="Falta el nombre")]
        public string GuestForenames { get; set; }
        [Display(Name="Apellidos")]
        [Required(ErrorMessage="Faltan los Apellidos")]
        public string GuestSurnames { get; set; }

        public DateTime GuestDOB { get; set; }
        [Display(Name="Street")]
        public string GuestAddressStreet { get; set; }
        [Display(Name="Town")]
        public string GuestAddressTown { get; set; }
        [Display(Name="Country")]
        public string GuestAddressCountry { get; set; }
        [Display(Name="Código postal")]
        public string GuestAddressPostaleCode { get; set; }
        [Display(Name="Numero Celular")]
        public string GuestContactPhone { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
    }
}