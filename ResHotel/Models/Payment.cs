using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models
{
    public class Payment
    {
        [Key]
        [Display(Name="ID")]
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int PaymentMethodID { get; set; }
        [Display(Name="pago")]
        [Required(ErrorMessage="monto pagado")]
        public int PaymentAmount { get; set; }
        [Display(Name="Comentarios")]
        public string PaymentComments { get; set; }
    }
}