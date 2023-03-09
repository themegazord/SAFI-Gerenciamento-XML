using Cassandra;

namespace safi_gerenciamento_xml.ManipulaExcel.Infrastructure.CassandraConnection
{
    public class CassandraConnection
    {
        public static ISession Session() {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            return cluster.Connect("safi_gerenciamento_xml");
        }
    }
}