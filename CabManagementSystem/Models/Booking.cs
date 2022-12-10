using Microsoft.CodeAnalysis;

namespace CabManagementSystem.Models
{
    public enum CarModels
    {
        Auto,
        Sedan,
        CUV,
        SUV
    }
    public enum Location
    {

        [Display(Name = "Vytilla Pub")]
        VytillaHub,
        [Display(Name = "Panampilly Nagar")]
        PanampillyNagar,
        Kakkanad,
        Edappally,
        Palarivattom,
        Kalamassery,
        [Display(Name = "North Railway Station")]
        NorthRailwayStation,
        [Display(Name = "South Railway Station")]
        SouthRailwayStation,
        Kaloor,
        Thripunithura,
        Thiruvankulam
    }
    public class Booking
    {
        public int Id { get; set; }



        [Required]
        [Display(Name = "Pick Up")]
        public Location From { get; set; }



        [Required]
        [Display(Name = "Destination")]
        public Location To { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public CarModels CarModel { get; set; }

        public ApplicationUser User { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }


        public DriverDetails? Driver { get; set; }
        [ForeignKey(nameof(Driver))]
        public int? DriverId { get; set; }

    }
}