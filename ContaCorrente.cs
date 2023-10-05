using System;
namespace Models;

class ContaCorrente : Conta, ITarifa {
  
  public ContaCorrente(double saldoAtual) : base(saldoAtual){
    CalcularTarifa();
  }

  public void CalcularTarifa() {
    Tarifa = SaldoAtual * 0.025 ;
  }
}
