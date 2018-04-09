using AutoMapper;
using SportApp2.Core.Domain;
using SportApp2.Infrastructure.DTO;

namespace SportApp2.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Food, FoodDto>();
                //    .ForMember(x => x.FoodTypeName, m => m.MapFrom(p => p.AvailableTickets.Count()))
                //    .ForMember(x => x.PurchasedTicketsCount, m => m.MapFrom(p => p.PurchasedTickets.Count()))
                //    .ForMember(x => x.TicketsCount, m => m.MapFrom(p => p.Tickets.Count()));
            })
            .CreateMapper();
    }
}
