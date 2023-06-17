namespace Tes3.Entites
{
    public class Product : IId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string? CountriesOfCreate { get; set; }
        public string Description { get; set; }
    }
}
