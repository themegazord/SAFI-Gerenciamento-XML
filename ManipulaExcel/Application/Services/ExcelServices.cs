using OfficeOpenXml;
using safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Contador;
using safi_gerenciamento_xml.ManipulaExcel.Application.Exceptions;
using safi_gerenciamento_xml.ManipulaExcel.Infrastructure.Repository.ContadorRepository;

namespace safi_gerenciamento_xml.ManipulaExcel.Application.Services
{
    public class ExcelServices
    {
        private readonly IContadorRepository _contadorRepository;

        public ExcelServices (IContadorRepository contadorRepository) {
            _contadorRepository = contadorRepository;
        }

        public void VerificaAPossibilidadeDeDarInsert(string path) {
            try {
                VerificaSeOPathEInvalido(path);
                VerificaSeOArquivoNaoExiste(path);
                List<Contadores> contadores = LerArquivoExcel(path);
                foreach(var contador in contadores) {
                    Insert(contador);
                }
                Console.WriteLine("Deu certo :D");
            } catch (ExcelException ex) {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            
        }

        private void Insert(Contadores contador) {
            _contadorRepository.Insert(contador);
        }

        private void VerificaSeOPathEInvalido(string path)
        {
            if (!Path.IsPathRooted(path)) {
                throw new ExcelException("O caminho passado para o sistema é inválido ou não pode ser alcançado!");
            }
        }

        private void VerificaSeOArquivoNaoExiste(string path)
        {
            if (!File.Exists(path)) {
                throw new ExcelException("O arquivo passado é inválido ou não existe.");
            }
        }

        private List<Contadores> LerArquivoExcel(string path)
        {
            var response = new List<Contadores>();
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage package = new(new FileInfo(path));
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.End.Row;

            for (int row = 2; row <= rowCount; row+= 1) {
                Contadores contador = new(worksheet.Cells[row, 1].Value.ToString(), worksheet.Cells[row, 2].Value.ToString());
                
                response.Add(contador);
            }

            return response;
        }
    }
}