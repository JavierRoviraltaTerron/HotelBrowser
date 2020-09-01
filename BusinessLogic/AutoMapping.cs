using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using HotelBrowser.BusinessLogic.Models;
using HotelBrowser.Domain.Models;

namespace HotelBrowser.BusinessLogic
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            CreateMap<Hotel, HotelDTO>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.Name, x => x.MapFrom(e => e.Name))
                .ForMember(x => x.Category, x => x.MapFrom(e => e.Category))
                .ForMember(x => x.ShortDescription, x => x.MapFrom(e => e.ShortDescription))
                .ForMember(x => x.Image, x => x.MapFrom(e => e.Image));

            CreateMap<HotelDTO, Hotel>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.Name, x => x.MapFrom(e => e.Name))
                .ForMember(x => x.Category, x => x.MapFrom(e => e.Category))
                .ForMember(x => x.ShortDescription, x => x.MapFrom(e => e.ShortDescription))
                .ForMember(x => x.Image, x => x.MapFrom(e => e.Image));
        }
    }
}
