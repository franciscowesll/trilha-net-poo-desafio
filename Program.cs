using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program 
{
    static void Main(string[] args)
    {
        Smartphone iphone= new Iphone(numero: "99991253460", modelo:"7", imei:"55-B", memoria:64);
        Smartphone nokia = new Nokia(numero:"9991884466", modelo:"AS", imei:"7784-C", memoria:128);
        
        Console.WriteLine("Smartphone Iphone:");
        iphone.Ligar();
        
        Console.WriteLine("");
        
          
        iphone.InstalarAplicativo("Anki");
        
        Console.WriteLine("");
        Console.WriteLine("");
        
        Console.WriteLine("Smartphone Nokia:");   
        nokia.Ligar();
        Console.WriteLine("");
        nokia.InstalarAplicativo("Telegram");
    }
}