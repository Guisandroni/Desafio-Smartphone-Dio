namespace Desafio_Celular_Dio.Models;

public abstract class Smartphone
{
    private string Modelo { get; set; }
    private string IMEI{ get; set; }
    private int Memoria{ get; set; }
    public string Numero { get; set; }
    
    
    public Smartphone(string modelo, string IMEI, int memoria, string numero)
    {
        this.Modelo = modelo;
        this.IMEI = IMEI;
        this.Memoria = memoria;
        this.Numero = numero;
    }
    
  

    public void Ligar()
    {
        Console.WriteLine("Ligando para contato");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo Ligacao");

    }

    public abstract void InstalarAplicativo(string nomeAplicativo);
}