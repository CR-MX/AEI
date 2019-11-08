using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models
{
    public class Customer
    {
        [Key]
        [Display(Name="ID")]
        public int CustomerID { get; set; }
        [Display(Name="Titulo")]
        public string CustomerTitle { get; set; }
        [Display(Name="Nombres")]
        public string CustomerForenames { get; set; }
        [Display(Name="Apellidos")]
        public string CustomerSurnames { get; set; }

        public DateTime CustomerDOB { get; set; }
        [Display(Name="Street")]
        public string CustomerAddressStreet { get; set; }
        [Display(Name="Town")]
        public string CustomerAddressTown { get; set; }
        [Display(Name="Country")]
        public string CustomerAddressCountry { get; set; }
        [Display(Name="Codigo Postal")]
        public string CustomerAddressPostalCode { get; set; }
        [Display(Name="Telefono de casa")]

        public string CustomerHomePhone { get; set; }
        [Display(Name="Telefono de trabajo")]
        public string CustomerWorkPhone { get; set; }
        [Display(Name="Telefono Mobil")]
        public string CustomerMobilPhone { get; set; }
        [Display(Name="Email")]
        public string CustomerCustomEmail { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}