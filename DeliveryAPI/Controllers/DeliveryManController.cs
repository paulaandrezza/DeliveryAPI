using Data.Repository.Interface;
using DeliveryAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryManController : ControllerBase
    {

        private readonly IDeliveryManRepository _deliveryManRepository;

        [HttpPost(Name = "AddDeliveryMan")]
        public IActionResult AddDeliveryMan(DeliveryMan deliveryMan)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}", Name = "DeleteDeliveryMan")]
        public IActionResult DeleteDeliveryMan(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet(Name = "GetAllDeliveryMen")]
        public IActionResult GetAllDeliveryMen()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "GetDeliveryManById")]
        public IActionResult GetDeliveryManById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("{id}", Name = "UpdateDeliveryMan")]
        public IActionResult UpdateDeliveryMan(int id, DeliveryMan deliveryMan)
        {
            throw new NotImplementedException();
        }
    }
}
