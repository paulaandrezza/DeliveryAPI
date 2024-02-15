using DeliveryAPI.Data.Enums;

namespace DeliveryAPI.RequestModels.Delivery
{
    public class CreateDeliveryRequest
    {
        public string RecipientName { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DeliveryStatus Status { get; set; }
    }
}
