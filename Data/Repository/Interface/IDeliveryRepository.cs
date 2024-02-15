using DeliveryAPI.Data;

namespace Data.Repository.Interface
{
    public interface IDeliveryRepository
    {
        Delivery GetDeliveryById(int id);
        IEnumerable<Delivery> GetAllDeliveries();
        IEnumerable<Delivery> GetAllDeliveriesFromADeliveryMan(DeliveryMan deliveryMan);
        void AddDelivery(Delivery delivery);
        void DeleteDelivery(Delivery delivery);
    }
}
