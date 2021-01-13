using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelReservation.Data.ViewModels.ReservationViewModels
{
    public abstract class AddUpdateReservationViewModel
    {
        public int Id { get; set; }

        [Required]
        public int? CustomerId { get; set; }

        [Required]
        public int? HotelId { get; set; }

        [Required]
        public DateTime AccommodationDate { get; set; }
    }
}
