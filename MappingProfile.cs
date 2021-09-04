using AutoMapper;
using BusinessLogicDataModel;
using EntityModel;
using InfoTrackGlobalTeamTechTest.Responses;
using System;
using DataModel = BusinessLogicDataModel;

namespace InfoTrackGlobalTeamTechTest
{
    /// <summary>
    /// MappingProfile
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// MappingProfile constructor
        /// </summary>
        public MappingProfile()
        {
            CreateMapping();
        }

        private void CreateMapping()
        {
            CreateMap<BookingInput, DataModel.Booking>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.From, opt => opt.MapFrom(src => src.BookingTime))
                .ForMember(dest => dest.To, opt => opt.MapFrom(src => DateTime.Parse(src.BookingTime).AddMinutes(59)))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<DataModel.Booking, EntityModel.Booking>().ReverseMap();
            CreateMap<DataModel.Booking, BookingResponse>().ForMember(dest => dest.BookingId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
