using AutoMapper;
using FFQueryBuilder.Models.Contexts;

namespace FFQueryBuilder.AutoMapperProfiles
{
    public class ContextProfile : Profile
    {
        public ContextProfile()
        {
            CreateMap<Microsoft.EntityFrameworkCore.Metadata.IProperty, ModelInfo>();
        }
    }
}
