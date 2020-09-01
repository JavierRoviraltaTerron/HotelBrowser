using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelBrowser.BusinessLogic.Interfaces;
using HotelBrowser.BusinessLogic.Models;
using HotelBrowser.Domain.Interfaces;
using HotelBrowser.Domain.Models;

namespace HotelBrowser.BusinessLogic.Services
{
    public class HotelService : IHotelService
    {
        private readonly IMapper _mapper;
        private IHotelRepository _holidayHomeOwnerRepository;

        public HotelService(IMapper mapper, IHotelRepository holidayHomeOwnerRepository) 
        {
            _mapper = mapper;
            _holidayHomeOwnerRepository = holidayHomeOwnerRepository;
        }

        public IEnumerable<HotelDTO> Get()
        {
            var repository = _holidayHomeOwnerRepository.Get();
            return _mapper.Map<IEnumerable<Hotel>,List<HotelDTO>>(repository);
        }
    }
}
