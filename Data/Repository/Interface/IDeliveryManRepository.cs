using DeliveryAPI.Data;

namespace Data.Repository.Interface
{
    public interface IDeliveryManRepository
    {
        DeliveryMan GetDeliveryManById(int id);
        DeliveryMan GetDeliveryManByCPF(string cpf);
        IEnumerable<DeliveryMan> GetAllDeliveryMen();
        void AddDeliveryMan(DeliveryMan deliveryMan);
        void DeleteDeliveryMan(DeliveryMan deliveryMan);
    }
}
