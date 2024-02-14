using Data.Repository.Interface;
using DeliveryAPI.Data;
using DeliveryAPI.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryManController : ControllerBase
    {

        private readonly IDeliveryManRepository _deliveryManRepository;

        public DeliveryManController(IDeliveryManRepository deliveryManRepository)
        {
            _deliveryManRepository = deliveryManRepository;
        }

        [HttpPost(Name = "AddDeliveryMan")]
        public IActionResult AddDeliveryMan(CreateDeliveryManRequest deliveryManRequest)
        {
            var deliveryMan = new DeliveryMan
            {
                Name = deliveryManRequest.Name,
                Phone = deliveryManRequest.Phone,
                VehicleType = deliveryManRequest.VehicleType,
                VehiclePlateNumber = deliveryManRequest.VehiclePlateNumber,
                DailyRate = deliveryManRequest.DailyRate
            };

            _deliveryManRepository.AddDeliveryMan(deliveryMan);
            return CreatedAtRoute("GetDeliveryManById", new { id = deliveryMan.Id }, "Created successfully");
        }

        [HttpDelete("{id}", Name = "DeleteDeliveryMan")]
        public IActionResult DeleteDeliveryMan(int id)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(id);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {id} was not found.");

            _deliveryManRepository.DeleteDeliveryMan(deliveryMan);
            return Ok("DeliveryMan deleted successfully.");

        }

        [HttpGet(Name = "GetAllDeliveryMen")]
        public IActionResult GetAllDeliveryMen()
        {
            return Ok(_deliveryManRepository.GetAllDeliveryMen());
        }

        [HttpGet("{id}", Name = "GetDeliveryManById")]
        public IActionResult GetDeliveryManById(int id)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(id);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {id} was not found.");
            return Ok(deliveryMan);
        }
    }
}
