using AutoMapper;
using FFQueryBuilder.AutoMapperProfiles;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FFQueryBuilder.Factories.Singleton
{
    internal sealed class AutoMapperSingleton
    {
        private static readonly Lazy<AutoMapperSingleton> _instance  = new Lazy<AutoMapperSingleton>(() => new AutoMapperSingleton(new ServiceCollection().AddAutoMapper(typeof(ContextProfile).Assembly).BuildServiceProvider()));
        private IMapper _mapper;

        public static AutoMapperSingleton Instance => _instance.Value;


        private AutoMapperSingleton(IServiceProvider serviceProvider) 
        {
            //serviceProvider = new ServiceCollection().AddSingleton<IMapper>().BuildServiceProvider();
            _mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public IMapper Mapper
        {
            get { return _mapper; }
        }
    }
}
