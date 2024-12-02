namespace ApiLocacaoCarro.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerDay { get; set; }
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;


        //relationships
        public int ModelId { get; set; }
        public ModelCar ModelCars { get; set; }
    }
}
