using System;
namespace Models;

class ContaInternacional : Conta, ITarifa {
  
  public ContaInternacional(double saldoAtual) : base(saldoAtual){
    ConverterSaldo();
    CalcularTarifa();
  }

  public void ConverterSaldo() {
    SaldoAtual *= 5;  
  }
  
  public void CalcularTarifa() {
    Tarifa =  SaldoAtual * 0.015;
  }
}
