using AutoMapper;
using PromoPage.Models;
using PromoPage.Models.PromoDb;
using System;
using System.Globalization;

namespace PromoPage.App_Start
{
    public class MappingConfig
    {

        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Seminar, SeminarData>()
                  .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.ParseExact(src.Date,
                  "yyyy-dd-MM HH:mm:ss.fff", CultureInfo.InvariantCulture)))
                  .ForMember(dest => dest.Time, opt => opt.MapFrom(src => src.Time))
                  .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location));

                cfg.CreateMap<ParticipantData, Participant>()
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                  .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                  .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                  .ForMember(dest => dest.TourAgency, opt => opt.MapFrom(src => src.TourAgency))
                  .ForMember(dest => dest.INN, opt => opt.MapFrom(src => src.INN))
                  .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                  .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                  .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            });
        }
    }
}