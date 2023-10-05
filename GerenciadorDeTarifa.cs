using System;
using System.Collections.Generic;
using System.Threading;

namespace Models;

class GerenciadorDeTarifa
{
  public delegate void Dados(string cpf,double saldo,double tarifa);
  public event Dados PegarDados;
  
  public delegate void Callback(string msg);
  
  public delegate void ProgressoSoma(int p);
  public event ProgressoSoma Progresso; 
  
  public void CalcularSaldoETarifaCliente(List<ArquivoDados> arquivoDados, Callback callback) {
    
    foreach (var linha in arquivoDados) {
      
      var valorTotalSaldo = 0d;
      var valorTotalTarifa = 0d;
      
      double valorContaCorrente = linha.ValorContaCorrente;
      double valorContaInternacional = linha.ValorContaInternacional;
      double valorContaCripto = linha.ValorContaCripto;

      var contaCorrente = new ContaCorrente(valorContaCorrente);
      var contaInternacional = new ContaInternacional(valorContaInternacional);
      var contaCripto = new ContaCripto(valorContaCripto);

      valorTotalSaldo = contaCorrente.SaldoAtual + contaInternacional.SaldoAtual + contaCripto.SaldoAtual;
      valorTotalTarifa = contaCorrente.Tarifa + contaInternacional.Tarifa;   
            
      for (var i=0; i<=10; i++){
      Thread.Sleep(300);
      Progresso?.Invoke(i);
      }      

      PegarDados?.Invoke(linha.Cpf,valorTotalSaldo,valorTotalTarifa);
      callback(linha.Cpf);
      
    }
  }
}
