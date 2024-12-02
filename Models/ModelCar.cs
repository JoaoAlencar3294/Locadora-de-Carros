namespace ApiLocacaoCarro.Models
{
    public class ModelCar
    {
        public int ModelCarId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;

        //relationships
        public ICollection<Car> Cars { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
