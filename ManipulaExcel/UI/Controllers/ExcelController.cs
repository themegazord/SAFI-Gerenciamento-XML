using safi_gerenciamento_xml.ManipulaExcel.Application.Services;

namespace safi_gerenciamento_xml.ManipulaExcel.UI.Controllers
{
    public class ExcelController
    {
        private readonly ExcelServices _excel_Services;
        public ExcelController(ExcelServices _excel_Services)
        {
            this._excel_Services = _excel_Services;
        }
        public void Insert(string path) {
            this._excel_Services.VerificaAPossibilidadeDeDarInsert(path);
        }
    }
}