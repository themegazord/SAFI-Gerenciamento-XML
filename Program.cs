// using safi_gerenciamento_xml.ManipulaExcel.Infrastructure.CassandraConnection;
using safi_gerenciamento_xml.ManipulaExcel.Application.Services;
using safi_gerenciamento_xml.ManipulaExcel.UI.Controllers;
// CassandraConnection.Session();

ExcelController controller = new ExcelController(new ExcelServices());
controller.Update("\\\\servidor\\Arquivos de Clientes\\XMLS\\Contadores.xlsx");