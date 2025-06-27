using System;

namespace TreinoHugo
{

  class Funcionario
  {
    public int Id{get; set;} = 0;
    public string Nome { get; set;} = string.Empty;

    public double Salario { get; set;} = 0.0;

    // Método para aumentar o salário do funcionário
    public void Aumentosalario(double porcentagem)
    {
      if (porcentagem > 0)
      {
        Salario += Salario * porcentagem / 100;
      }
    }
  
  
  }   

  
}
