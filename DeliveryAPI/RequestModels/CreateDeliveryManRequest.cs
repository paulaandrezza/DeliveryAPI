using DeliveryAPI.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace DeliveryAPI.RequestModels
{
    public class CreateDeliveryManRequest
    {
        [Required(ErrorMessage = "O nome do entregador é obrigatório.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O número de telefone do entregador é obrigatório.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "O tipo de veículo é obrigatório.")]
        public VehicleType VehicleType { get; set; }
        [Required(ErrorMessage = "O número da placa do veículo é obrigatório.")]
        public string VehiclePlateNumber { get; set; }
        [Required(ErrorMessage = "A taxa diária do entregador é obrigatória.")]
        public double DailyRate { get; set; }
    }
}
