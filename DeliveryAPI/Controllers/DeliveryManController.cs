using Data.Repository.Interface;
using DeliveryAPI.Data;
using DeliveryAPI.Filters;
using DeliveryAPI.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [TypeFilter(typeof(AuthorizationFilter))]
    [Authorize]
    public class DeliveryManController : ControllerBase
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IDeliveryManRepository _deliveryManRepository;

        public DeliveryManController(IDeliveryRepository deliveryRepository, IDeliveryManRepository deliveryManRepository)
        {
            _deliveryRepository = deliveryRepository;
            _deliveryManRepository = deliveryManRepository;
        }

        [HttpPost(Name = "AddDeliveryMan")]
        public IActionResult AddDeliveryMan([FromBody] CreateDeliveryManRequest deliveryManRequest)
        {
            DeliveryMan deliveryMan = new DeliveryMan
            {
                Name = deliveryManRequest.Name,
                CPF = deliveryManRequest.CPF,
                Phone = deliveryManRequest.Phone,
                VehicleType = deliveryManRequest.VehicleType,
                VehiclePlateNumber = deliveryManRequest.VehiclePlateNumber,
                DailyRate = deliveryManRequest.DailyRate
            };

            _deliveryManRepository.AddDeliveryMan(deliveryMan);
            return CreatedAtRoute("GetDeliveryManById", new { deliveryManId = deliveryMan.Id }, "Created successfully");
        }

        [HttpDelete("{deliveryManId}", Name = "DeleteDeliveryMan")]
        public IActionResult DeleteDeliveryMan([FromRoute] int deliveryManId)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(deliveryManId);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {deliveryManId} was not found.");

            _deliveryManRepository.DeleteDeliveryMan(deliveryMan);
            return Ok("DeliveryMan deleted successfully.");

        }

        [HttpGet(Name = "GetAllDeliveryMen")]
        public IActionResult GetAllDeliveryMen([FromQuery] string? deliveryManCPF = null)
        {
            if (deliveryManCPF != null)
            {
                DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManByCPF(deliveryManCPF);
                if (deliveryMan == null)
                    return NotFound($"The delivery man with CPF {deliveryManCPF} was not found.");
                return Ok(deliveryMan);
            }

            return Ok(_deliveryManRepository.GetAllDeliveryMen());
        }

        [HttpGet("{deliveryManId}", Name = "GetDeliveryManById")]
        public IActionResult GetDeliveryManById([FromRoute] int deliveryManId)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(deliveryManId);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {deliveryManId} was not found.");
            return Ok(deliveryMan);
        }

        [HttpGet("bycpf/{deliveryManCPF}", Name = "GetDeliveryManByCPF")]
        public IActionResult GetDeliveryManByCPF([FromRoute] string deliveryManCPF)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManByCPF(deliveryManCPF);
            if (deliveryMan == null)
                return NotFound($"The delivery man with CPF {deliveryManCPF} was not found.");
            return Ok(deliveryMan);
        }

        [HttpGet("deliveries/{deliveryManId}", Name = "GetAllDeliveriesFromADeliveryMan")]
        public IActionResult GetAllDeliveriesFromADeliveryMan([FromRoute] int deliveryManId)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(deliveryManId);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {deliveryManId} was not found.");

            return Ok(_deliveryRepository.GetAllDeliveriesFromADeliveryMan(deliveryMan));
        }
    }
}
