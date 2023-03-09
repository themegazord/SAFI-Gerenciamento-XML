// using safi_gerenciamento_xml.ManipulaExcel.Infrastructure.CassandraConnection;
using safi_gerenciamento_xml.ManipulaExcel.Application.Services;
using safi_gerenciamento_xml.ManipulaExcel.UI.Controllers;
using safi_gerenciamento_xml.ManipulaExcel.Infrastructure.Repository.ContadorRepository;
using safi_gerenciamento_xml.ManipulaExcel.Infrastructure.CassandraConnection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<IContadorRepository, ContadorRepository>();
        ExcelController controller = new ExcelController(new ExcelServices(new ContadorRepository(CassandraConnection.Session())));
        controller.Insert("\\\\servidor\\Arquivos de Clientes\\XMLS\\Contadores.xlsx");
    });

await builder.RunConsoleAsync();







