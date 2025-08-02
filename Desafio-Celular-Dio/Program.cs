// See https://aka.ms/new-console-template for more information


using Desafio_Celular_Dio.Models;


class Programs
{
  public static void Main(string[] args)
  {
    Iphone iphone = new Iphone("12441", " Iphone Pro 1012", "00304", 4096);

    Nokia nokia = new Nokia("12331", "Nokia Xp 2012", "003403", 512);

  
    
    bool option = true;
    while (option)
    {
      Console.WriteLine("\n1 - Smartphone Nokia");
      Console.WriteLine("2 - Smartphone Iphone ");
      Console.WriteLine("3- Sair \n");

      string acao = Console.ReadLine();
      switch (acao)
      {
        case "1":
          FuncoesSmartphone(nokia);
          break;
        case "2":
          FuncoesSmartphone(iphone);
          break;
        
        default:
          Environment.Exit(3);
          break;
      }
      
    }
  }

  public static void FuncoesSmartphone(Smartphone smartphone)
  {

    bool sair = true;
    while (sair)
    {
      Console.WriteLine("1 - Fazer ligação");
      Console.WriteLine("2 - Receber ligação ");
      Console.WriteLine("3 - Instalar aplicativo ");
      Console.WriteLine("4 - Sair ");

      string acao = Console.ReadLine();
      switch (acao)
      {
        case "1":
          smartphone.Ligar();
          break;
        case "2":
          smartphone.ReceberLigacao();
          break;
        case "3":
          string nomeAplicativo = Console.ReadLine();
          smartphone.InstalarAplicativo(nomeAplicativo);
          break;
     
        default:
          Environment.Exit(4);
          break;
      }
      
    }
  }
}
    