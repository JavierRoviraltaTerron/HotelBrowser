using System;
using System.Collections.Generic;
using System.Text;
using HotelBrowser.BusinessLogic.Models;

namespace HotelBrowser.BusinessLogic.Interfaces
{
    public interface IHotelService
    {
        public IEnumerable<HotelDTO> Get();
    }
}
