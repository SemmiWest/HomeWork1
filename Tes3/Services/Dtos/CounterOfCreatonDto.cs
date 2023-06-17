using Tes3.Entites;
using Tes3.Services.Mapper;

namespace Tes3.Services.Dtos
{
    public class CounterOfCreatonDto : IMapFrom<CountersOfCreaton>
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
