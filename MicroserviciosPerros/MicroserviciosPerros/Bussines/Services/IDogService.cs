using MicroserviciosPerros.Data.DTO_s;

namespace MicroserviciosPerros.Bussines.Services
{
    public interface IDogService
    {
        int Insert(DogDTO dto);
        List<DogDTO> GetAll();
        int Delete(int id);
    }
}
