using System;
using System.Globalization;

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
      double.TryParse(Console.ReadLine(), out pessoa1.Salario);
      Console.WriteLine("Digite o nome do segundo funcionario:");
      pessoa2.Nome = Console.ReadLine();
      Console.WriteLine("Digite o salário do segundo funcioanario:");
      double.TryParse(Console.ReadLine(), out pessoa2.Salario);
      double soma = (pessoa1.Salario + pessoa2.Salario) / 2;

      Console.WriteLine("A media do salário de " + pessoa1.Nome + " e " + pessoa2.Nome + " é de R$" + soma.ToString("F2", CultureInfo.InvariantCulture));


    }
  }
}