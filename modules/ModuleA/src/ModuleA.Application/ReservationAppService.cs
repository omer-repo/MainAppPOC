using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace ModuleA
{
    public class ReservationAppService : ModuleAAppService
    {
        private readonly IRepository<Reservation, Guid> _repository;

        public ReservationAppService(IRepository<Reservation, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<ReservationDto>> GetList()
        {
            return ObjectMapper.Map<List<Reservation>, List<ReservationDto>>(await _repository.GetListAsync());
        }

        public async Task<ReservationDto> CreateAsync(ReservationDto reservationDto)
        {
            var reservation = ObjectMapper.Map<ReservationDto, Reservation>(reservationDto);
            reservation = await _repository.InsertAsync(reservation, true);

            return ObjectMapper.Map<Reservation, ReservationDto>(reservation);
        }

        public async Task<ReservationDto> UpdateAsync(Guid id, ReservationDto reservationDto)
        {
            var reservation = ObjectMapper.Map<ReservationDto, Reservation>(reservationDto);
            var updatedReservation = await _repository.UpdateAsync(reservation, true);
            return ObjectMapper.Map<Reservation, ReservationDto>(updatedReservation);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }


    }
}
