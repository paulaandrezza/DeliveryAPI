using Data.Repository.Interface;
using DeliveryAPI.Data;

namespace Data.Repository
{
    public class DeliveryRepositoryInMemory : IDeliveryRepository
    {
        private readonly List<Delivery> _deliveries = new List<Delivery>();
        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        public void DeleteDelivery(Delivery delivery)
        {
            _deliveries.Remove(delivery);
        }

        public IEnumerable<Delivery> GetAllDeliveries()
        {
            return _deliveries;
        }

        public IEnumerable<Delivery> GetAllDeliveriesFromADeliveryMan(DeliveryMan deliveryMan)
        {
            return _deliveries.Where(delivery => delivery.DeliveryMan == deliveryMan);
        }

        public Delivery GetDeliveryById(int id)
        {
            return _deliveries.FirstOrDefault(delivery => delivery.Id == id);
        }
    }
}
