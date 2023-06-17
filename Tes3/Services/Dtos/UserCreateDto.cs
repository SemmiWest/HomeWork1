using Tes3.Services.Mapper;
using Tes3.Entites;
namespace Tes3.Services.Dtos
{
    public class UserCreateDto: IMapTo<User>
    {
        
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
