using safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Contador;

namespace safi_gerenciamento_xml.ManipulaExcel.Infrastructure.Repository.ContadorRepository
{
    public interface IContadorRepository
    {
        void Insert(Contadores contador);
    }
}