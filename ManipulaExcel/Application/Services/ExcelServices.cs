using OfficeOpenXml;
using safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Contador;
using safi_gerenciamento_xml.ManipulaExcel.Domain.Exceptions;


namespace safi_gerenciamento_xml.ManipulaExcel.Application.Services
{
    public class ExcelServices
    {
        public void VerificaAPossibilidadeDeDarUpdate(string path) {
            try {
                VerificaSeOPathEInvalido(path);
                VerificaSeOArquivoNaoExiste(path);
                List<ContadorDTO> contadores = LerArquivoExcel(path);
                foreach(var contador in contadores) {
                    Console.WriteLine($"Nome do contador: {contador.nome_Contador}\nEmail do Contador: {contador.email_Contador}\n----###----\n");
                }
                Console.WriteLine("Deu certo :D");
            } catch (ExcelException ex) {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            
        }
        private void VerificaSeOPathEInvalido(string path) {
            if (!Path.IsPathRooted(path)) {
                ExcelException.PathInvalido();
            }
        }
        private void VerificaSeOArquivoNaoExiste(string path) {
            if (!File.Exists(path)) {
                ExcelException.ArquivoInvalido();
            }
        }

        private List<ContadorDTO> LerArquivoExcel(string path) {
            var response = new List<ContadorDTO>();
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage package = new(new FileInfo(path));
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.End.Row;

            for (int row = 2; row <= rowCount; row+= 1) {
                ContadorDTO contador = new(worksheet.Cells[row, 1].Value.ToString(), worksheet.Cells[row, 2].Value.ToString());

                response.Add(contador);
            }

            return response;
        }
    }
}