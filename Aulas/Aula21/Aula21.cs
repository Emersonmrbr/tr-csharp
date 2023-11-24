using System;
class Aula21
{
  static void Main()
  {
    //   int num = 5;
    //   while (num < 5)
    //   {
    //     Console.WriteLine("MAP curso");
    //   }

    //   do
    //   {
    //     Console.WriteLine("MAP curso 2");
    //   } while (num < 5);
    string senha = "123";
    string userSenha;
    int tentativas = 0;

    do
    {
      Console.Clear();
      Console.WriteLine("Digite a senha");
      userSenha = Console.ReadLine();
      tentativas++;
    } while (senha != userSenha);
    Console.Clear();
    Console.WriteLine("Senha correta, tentativas : {0}", tentativas);
  }
}