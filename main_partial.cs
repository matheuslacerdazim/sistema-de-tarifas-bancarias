using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Models;

partial class Program {

  static void GerarArquivoCliente(string cpf, double vlrTotalSaldo, double vlrTarifaTotal) {
    var arq = $"{Environment.CurrentDirectory}/{cpf}.txt";

    string[] linhas = new string[] {
      $"Cpf: {cpf}",
      $"Valor Total de Saldo: {vlrTotalSaldo}",
      $"Valor Total de Tarifa: {vlrTarifaTotal}"
    };
    
    File.Create(arq).Close();
    File.WriteAllLines(arq,linhas);    
  }

   static void ImprimirProgresso(int value){
      Console.Clear();
      Console.WriteLine($"Calculo de tarifas em progresso... {value}");
    }
  
  static void ExibirMensagemArquivoGerado(string cpf) {
    Console.WriteLine($"Arquivo gerado com sucesso para o cpf: {cpf}");
    Thread.Sleep(2000);
  }

  static List<ArquivoDados> LerArquivoClientes(){
    var arq = $"{Environment.CurrentDirectory}/Dados.txt";

    var linhas = File.ReadAllLines(arq);
    var lista = linhas.Select(linha => {
      var campos = linha.Split("|");
      return new ArquivoDados {
        Cpf = campos[0],
        Nome = campos[1],
        ValorContaCorrente = double.Parse(campos[2]),
        ValorContaInternacional = double.Parse(campos[3]),
        ValorContaCripto = double.Parse(campos[4])
      };
    }).ToList();
    return lista;
  }    
}
