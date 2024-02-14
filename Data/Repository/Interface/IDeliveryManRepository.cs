using DeliveryAPI.Data;

namespace Data.Repository.Interface
{
    public interface IDeliveryManRepository
    {
        DeliveryMan GetDeliveryManById(int id);
        IEnumerable<DeliveryMan> GetAllDeliveryMen();
        int AddDeliveryMan(DeliveryMan deliveryMan);
        int UpdateDeliveryMan(int id, DeliveryMan deliveryMan);
        void DeleteDeliveryMan(int id);
    }
}
