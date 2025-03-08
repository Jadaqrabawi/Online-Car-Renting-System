namespace RoyalCarRentalSystem.Models
{
    public class BookingDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DrivingLicense { get; set; }
        public string Email { get; set; }
        public int CarId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
    }
}