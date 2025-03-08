namespace RoyalCarRentalSystem.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }
        public string ImageUrl { get; set; }
        public int Seats { get; set; }
        public int Luggage { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
    }
}