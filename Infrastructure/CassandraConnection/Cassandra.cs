using Cassandra;

namespace safi_gerenciamento_xml.Infrastructure.CassandraConnection
{
    public class CassandraConnection
    {
        public static void Session() {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            var session = cluster.Connect("safi_gerenciamento_xml");
        }
    }
}