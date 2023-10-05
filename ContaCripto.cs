using System;
namespace Models;

class ContaCripto : Conta {
  
  public ContaCripto(double saldoAtual) : base(saldoAtual){
    ConverterSaldo();
  }

  protected void ConverterSaldo() {
    SaldoAtual *= 5;
  } 
}
