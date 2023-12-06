using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ModuleA
{
    public class Reservation: Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime ReservationDate { get; set; }
        public Guid HotelId { get; set; }
    }
}
