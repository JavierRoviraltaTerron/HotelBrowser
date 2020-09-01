using System;
using System.Collections.Generic;
using System.Text;
using HotelBrowser.Domain.Models;

namespace HotelBrowser.Domain.Interfaces
{
    public interface IHotelRepository
    {
        public IEnumerable<Hotel> Get();
    }
}
