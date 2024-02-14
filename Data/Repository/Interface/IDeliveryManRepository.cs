using DeliveryAPI.Data;

namespace Data.Repository.Interface
{
    public interface IDeliveryManRepository
    {
        DeliveryMan GetDeliveryManById(int id);
        IEnumerable<DeliveryMan> GetAllDeliveryMen();
        void AddDeliveryMan(DeliveryMan deliveryMan);
        void DeleteDeliveryMan(DeliveryMan deliveryMan);
    }
}
