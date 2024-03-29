using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResHotel.Models
{
    public class Booking
    {
        [Key]
        [Display(Name="ID")]
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        [Display(Name="Fecha de reserva")]
        [Required(ErrorMessage="Faltan la Fecha de reserva ")]
        public DateTime DateBookingMade { get; set; }
        [Display(Name="Tiempo de reserva")]
        public string TimeBookingMade { get; set; }
        [Display(Name="Fecha inical de reserva")]
        public DateTime BookedStartDate { get; set; }
        [Display(Name="Fecha terminal de reserva")]
        public DateTime BookedEndDate { get; set; }
        [Display(Name="Fecha de pago")]
        public DateTime TotalPaymentDueDate { get; set; }
        [Display(Name="Monto total pagado")]
        public int TotalPaymentDueAmount { get; set; }
        [Display(Name="Fecha de pago")]
        public DateTime TotalPaymentMadeOn { get; set; }
        [Display(Name="Comentarios")]
        public string BookingComments { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
    }
}