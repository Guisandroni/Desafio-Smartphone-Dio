namespace Desafio_Celular_Dio.Models;

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(modelo,imei,memoria,numero)
    {
        
    }

    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando aplicativo {nomeAplicativo} ");
    }
}