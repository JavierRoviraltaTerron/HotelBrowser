using System;
using System.Collections.Generic;

namespace HotelBrowser.Domain.Models
{
    public partial class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
    }
}
