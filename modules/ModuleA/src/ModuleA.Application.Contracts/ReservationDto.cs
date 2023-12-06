using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ModuleA
{
    public class ReservationDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime ReservationDate { get; set; }
        public Guid HotelId { get; set; }
    }
}
