using Tes3.Services.Mapper;
using Tes3.Entites;

namespace Tes3.Services.Dtos
{
    public class CourierDto : IMapFrom<Courier>

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
