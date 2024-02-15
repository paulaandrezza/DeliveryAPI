using DeliveryAPI.Data.Enums;

namespace DeliveryAPI.Data
{
    public class DeliveryMan
    {
        private static int _id = 1;

        public DeliveryMan()
        {
            Id = _id++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public VehicleType VehicleType { get; set; }
        public string VehiclePlateNumber { get; set; }
        public double DailyRate { get; set; }
    }
}
