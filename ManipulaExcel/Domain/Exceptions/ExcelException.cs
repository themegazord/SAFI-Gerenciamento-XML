namespace safi_gerenciamento_xml.ManipulaExcel.Domain.Exceptions
{
    public class ExcelException : Exception
    {
        public static void PathInvalido() {
            throw new Exception("O caminho passado para o sistema é inválido ou não pode ser alcançado!");
        }

        public static void ArquivoInvalido() {
            throw new Exception("O arquivo passado é inválido ou não existe.");
        }
    }
}