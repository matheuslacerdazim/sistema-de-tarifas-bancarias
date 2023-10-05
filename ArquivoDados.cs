namespace Models;

class ArquivoDados{
  
  public string Cpf {get;set;}
  public string Nome {get;set;}
  public double ValorContaCorrente {get;set;}
  public double ValorContaInternacional{get;set;}
  public double ValorContaCripto{get;set;}

  public override string ToString(){
    return $"{Cpf} - {Nome} - {ValorContaCorrente} - {ValorContaInternacional} - {ValorContaCripto}";
  }  
}
