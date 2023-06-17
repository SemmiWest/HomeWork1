using Tes3.Entites;
using Tes3.Services.Mapper;

namespace Tes3.Services.Dtos
{

    public class ProductDto : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string? CountriesOfCreate { get; set; }
        public string Description { get; set; }
    }
}
