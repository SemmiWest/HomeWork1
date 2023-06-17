using Tes3.Services.Mapper;
using Tes3.Entites;

namespace Tes3.Services.Dtos
{
    public class UserDto : IMapFrom<User>

    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
