using Tes3.Entites;
using Tes3.Services.Mapper;

namespace Tes3.Services.Dtos
{
    public class ShoppingListDro : IMapFrom<ShoppingList>
    {
        public int Id { get; set; }

        public UserDto User{ get; set; }

        public ProductDto Product { get; set; }

        public CourierDto Courier { get; set; }

    }
}
