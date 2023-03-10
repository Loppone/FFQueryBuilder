using AutoMapper;
using FFQueryBuilder.Models.Contexts;

namespace FFQueryBuilder.AutoMapperProfiles
{
    public class ContextProfile : Profile
    {
        public ContextProfile()
        {
            CreateMap<Microsoft.EntityFrameworkCore.Metadata.IProperty, ModelInfo>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetTypeMapping().ClrType.Name))
                .ForMember(dest => dest.MaxLength, opt => opt.MapFrom(src => src.GetMaxLength()));
        }
    }
}
