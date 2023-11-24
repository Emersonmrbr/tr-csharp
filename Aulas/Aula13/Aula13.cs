using System;
class Aula13
{
  public static void Main(){
    // int nota = 0;
    // string resultado = "Reprovado";
    // nota = Convert.ToInt32(Console.ReadLine());
    // if (nota >= 60)
    // {
    //   resultado = "Aprovado";
    // }
    // Console.WriteLine("Resultado: {0}", resultado);
    int n1,n2,n3,n4;
    n1=n2=n3=n4=0;
    int res = 0;
    string resultado;

    Console.WriteLine("Digite a nota 1");
    n1 = Convert.ToInt32( Console.ReadLine());
    Console.WriteLine("Digite a nota 2");
    n2 = Convert.ToInt32( Console.ReadLine());
    Console.WriteLine("Digite a nota 3");
    n3 = Convert.ToInt32( Console.ReadLine());
    Console.WriteLine("Digite a nota 4");
    n4 = Convert.ToInt32( Console.ReadLine());

    res = n1+n2 + n3 + n4;

    if (res < 40)
    {
      resultado = "Reprovado";
    }else if (res < 60){
      resultado = "recuperação";
    } else{
      resultado = "Aprovado";
    }
    Console.WriteLine("Nota: {0} - Resultado: {1}" ,res, resultado);
  }
}