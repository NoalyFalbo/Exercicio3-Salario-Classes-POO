using System;

namespace exercicioClasses3
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Funcionario pessoa1 = new Funcionario();
      Funcionario pessoa2 = new Funcionario();

      Console.WriteLine("Digite o nome do primeiro funcionario:");
      pessoa1.Nome = Console.ReadLine();
      Console.WriteLine("Digite o salário do primeiro funcioanario:");
      double.TryParse(Console.ReadLine(), out pessoa1.salario);
      Console.WriteLine("Digite o nome do segundo funcionario:");
      pessoa2.Nome = Console.ReadLine();
      Console.WriteLine("Digite o salário do segundo funcioanario:");
      double.TryParse(Console.ReadLine(), out pessoa2.salario);

    }
  }
}