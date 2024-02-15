using DeliveryAPI.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace DeliveryAPI.RequestModels
{
    public class CreateDeliveryRequest
    {
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public string DestinationAddress { get; set; }
        [Required]
        public DateTime? OrderDate { get; set; }
        [Required]
        public DateTime? DeliveryDate { get; set; }
        [Required]
        public DeliveryStatus? Status { get; set; }
    }
}
