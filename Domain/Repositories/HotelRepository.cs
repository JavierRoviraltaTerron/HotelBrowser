using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelBrowser.Domain.Interfaces;
using HotelBrowser.Domain.Models;

namespace HotelBrowser.BusinessLogic.Services
{
    public class HotelRepository : IHotelRepository
    {
        public IEnumerable<Hotel> Get()
        {
            using (var dbContext = new HotelBrowserContext())
            {
                return dbContext.Hotel.ToList();
            }
        }
    }
}
