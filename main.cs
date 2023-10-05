using Models;

partial class Program {
  
  public static void Main (string[] args) {
    
    var lista = LerArquivoClientes();
    var gerenciador = new GerenciadorDeTarifa();
    
    gerenciador.PegarDados += GerarArquivoCliente;
    gerenciador.Progresso += ImprimirProgresso;
    gerenciador.CalcularSaldoETarifaCliente(lista, ExibirMensagemArquivoGerado);   
  }   
}
