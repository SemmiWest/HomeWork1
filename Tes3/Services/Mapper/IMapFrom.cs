using AutoMapper;

namespace Tes3.Services.Mapper
{
    public interface IMapFrom<T>
    {
        void MappingFrom(Profile profile)
        {
            profile.CreateMap(typeof(T), GetType());
        }
    }
}
