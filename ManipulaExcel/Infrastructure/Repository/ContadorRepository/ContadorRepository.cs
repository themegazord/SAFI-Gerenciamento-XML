using Cassandra;
using Cassandra.Data.Linq;
using safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Contador;

namespace safi_gerenciamento_xml.ManipulaExcel.Infrastructure.Repository.ContadorRepository
{
    public class ContadorRepository : IContadorRepository
    {
        private ISession _session;
        private Table<Contadores> _contadoresTable;
        public ContadorRepository(ISession session) {
            _session = session;
            _contadoresTable = new Table<Contadores>(_session);
        }
        public void Insert(Contadores contador)
        {
            _contadoresTable.Insert(contador).Execute();
        }
    }
}