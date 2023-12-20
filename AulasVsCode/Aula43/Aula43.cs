using System;

public interface Veiculo
{
  void ligar();
  void desligar();
  void info();
}
public interface Combate
{
  void disparar();
}
class Carro : Veiculo, Combate
{
  public bool ligado;
  private int municao;
  public Carro()
  {
    setMunicao(100);
  }
  public void setMunicao(int qtde)
  {
    this.municao = qtde;
  }
  public void ligar()
  {
    this.ligado = true;
  }
  public void desligar()
  {
    this.ligado = false;
  }
  public void info() { }
  public void disparar() { }
}

class Aula43
{
  static void Main()
  {
    Carro tiida = new Carro();
  }
}