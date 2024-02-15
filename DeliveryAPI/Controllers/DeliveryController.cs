using Data.Repository.Interface;
using DeliveryAPI.Data;
using DeliveryAPI.Filters;
using DeliveryAPI.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [TypeFilter(typeof(AuthorizationFilter))]
    public class DeliveryController : Controller
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IDeliveryManRepository _deliveryManRepository;

        public DeliveryController(IDeliveryRepository deliveryRepository, IDeliveryManRepository deliveryManRepository)
        {
            _deliveryRepository = deliveryRepository;
            _deliveryManRepository = deliveryManRepository;
        }
        [HttpPost("{deliveryManId}", Name = "AddDelivery")]
        public IActionResult AddDelivery([FromRoute] int deliveryManId, [FromBody] CreateDeliveryRequest deliveryRequest)
        {
            DeliveryMan deliveryMan = _deliveryManRepository.GetDeliveryManById(deliveryManId);
            if (deliveryMan == null)
                return NotFound($"The delivery man with ID {deliveryManId} was not found.");

            Delivery delivery = new Delivery()
            {
                RecipientName = deliveryRequest.RecipientName,
                DestinationAddress = deliveryRequest.DestinationAddress,
                OrderDate = deliveryRequest.OrderDate,
                DeliveryDate = deliveryRequest.DeliveryDate,
                Status = deliveryRequest.Status,
                DeliveryMan = deliveryMan
            };

            _deliveryRepository.AddDelivery(delivery);
            return CreatedAtRoute("GetDeliveryById", new { deliveryId = delivery.Id }, "Created successfully");
        }

        [HttpDelete("{deliveryId}", Name = "DeleteDelivery")]
        public IActionResult DeleteDelivery([FromRoute] int deliveryId)
        {
            Delivery delivery = _deliveryRepository.GetDeliveryById(deliveryId);
            if (delivery == null)
                return NotFound($"The delivery with ID {deliveryId} was not found.");

            _deliveryRepository.DeleteDelivery(delivery);
            return Ok("Delivery deleted sycessfully.");
        }

        [HttpGet(Name = "GetAllDeliveries")]
        public IActionResult GetAllDeliveries()
        {
            return Ok(_deliveryRepository.GetAllDeliveries());
        }

        [HttpGet("{deliveryId}", Name = "GetDeliveryById")]
        public IActionResult GetDeliveryById([FromRoute] int deliveryId)
        {
            Delivery delivery = _deliveryRepository.GetDeliveryById(deliveryId);
            if (delivery == null)
                return NotFound($"The delivery with ID {deliveryId} was not found.");

            return Ok(delivery);
        }

        [HttpGet("Exception", Name = "TestException")]
        public IActionResult TestException([FromQuery] bool error)
        {
            if (error)
                throw new Exception("This is a test exception from the DeliveryController");

            return Ok();
        }
    }
}
