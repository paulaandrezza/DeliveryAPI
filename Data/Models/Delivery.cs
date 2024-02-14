using DeliveryAPI.Data.Enums;

namespace DeliveryAPI.Data
{
    public class Delivery
    {
        public int Id { get; set; }
        public string RecipientName { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DeliveryStatus Status { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
    }
}
