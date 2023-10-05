using System;
namespace Models;

public abstract class Conta {

  public virtual double SaldoAtual {get; set;}
  public double Tarifa{get; set; }

  public Conta (double saldoAtual) {
    SaldoAtual = saldoAtual;
  }

  public override string ToString() {
    return $"Saldo: {SaldoAtual}";
  }
}
