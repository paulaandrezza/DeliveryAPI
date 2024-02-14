using DeliveryAPI.Data.Enums;

namespace DeliveryAPI.RequestModels
{
    public class UpdateDeliveryManRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public VehicleType VehicleType { get; set; }
        public string VehiclePlateNumber { get; set; }
        public double DailyRate { get; set; }
    }
}
