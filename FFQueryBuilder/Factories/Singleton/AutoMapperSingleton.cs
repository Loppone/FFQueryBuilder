using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace FFQueryBuilder.Factories.Singleton
{
    internal sealed class AutoMapperSingleton
    {
        private static readonly AutoMapperSingleton _instance = new AutoMapperSingleton();
        private IMapper _mapper;

        private AutoMapperSingleton() 
        {
            var serviceProvider = new ServiceCollection().AddSingleton<IMapper>().BuildServiceProvider();
            _mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public static AutoMapperSingleton Instance
        {
            get { return _instance; }
        }

        public IMapper Mapper
        {
            get { return _mapper; }
        }
    }
}
