namespace ApiLocacaoCarro.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; } = string.Empty;

        //relationships
        public ICollection<ModelCar> ModelsCars { get; set; }
    }
}
