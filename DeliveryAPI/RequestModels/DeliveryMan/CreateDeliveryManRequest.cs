using DeliveryAPI.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace DeliveryAPI.RequestModels.DeliveryMan
{
    public class CreateDeliveryManRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(11)]
        public string CPF { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public VehicleType VehicleType { get; set; }
        [Required]
        public string VehiclePlateNumber { get; set; }
        [Required]
        public double DailyRate { get; set; }
    }
}
