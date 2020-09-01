using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBrowser.BusinessLogic.Models
{
    public class HotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
    }
}
