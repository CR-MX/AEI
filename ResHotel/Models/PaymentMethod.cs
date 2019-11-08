using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models
{
    public class PaymentMethod
    {
        [Key]
        [Display(Name="ID")]
        public int PaymentMethodID { get; set; }
        [Display(Name="Metodo de pago")]
        [Required(ErrorMessage="Escribe el metodo de pago")]
        public string PaymentMethods { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}