using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelReservation.Data.ViewModels.HotelViewModels
{
    public class AddUpdateHotelViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public int? Rating { get; set; }

        [Required]
        public int? AvailableRooms { get; set; }
    }
}
