using Data.Repository.Interface;
using DeliveryAPI.Data;

namespace Data.Repository
{
    public class DeliveryManRepositoryInMemory : IDeliveryManRepository
    {
        private readonly List<DeliveryMan> _deliveryMen = new List<DeliveryMan>();
        public void AddDeliveryMan(DeliveryMan deliveryMan)
        {
            _deliveryMen.Add(deliveryMan);
        }

        public void DeleteDeliveryMan(DeliveryMan deliveryMan)
        {
            _deliveryMen.Remove(deliveryMan);
        }

        public IEnumerable<DeliveryMan> GetAllDeliveryMen()
        {
            return _deliveryMen;
        }

        public DeliveryMan GetDeliveryManById(int id)
        {
            return _deliveryMen.FirstOrDefault(deliveryMan => deliveryMan.Id == id);
        }
    }
}
