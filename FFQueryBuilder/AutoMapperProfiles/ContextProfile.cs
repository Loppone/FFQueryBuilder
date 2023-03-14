using AutoMapper;
using FFQueryBuilder.Models.Contexts;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace FFQueryBuilder.AutoMapperProfiles
{
    public class ContextProfile : Profile
    {
        public ContextProfile()
        {
            CreateMap<Microsoft.EntityFrameworkCore.Metadata.IProperty, ModelInfo>()
                .ForMember(dest => dest.IsPrimaryKey, opt => opt.MapFrom<CustomResolver>())
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetTypeMapping().ClrType.Name))
                .ForMember(dest => dest.MaxLength, opt => opt.MapFrom(src => src.GetMaxLength()));
        }
    }

    public class CustomResolver : IValueResolver<IProperty, ModelInfo, bool>
    {
        public bool Resolve(IProperty source, ModelInfo destination, bool destMember, ResolutionContext context)
        {
            var primaryKey = source.DeclaringEntityType.FindPrimaryKey();
            return primaryKey.Properties.Contains(source);
        }
    }
}
