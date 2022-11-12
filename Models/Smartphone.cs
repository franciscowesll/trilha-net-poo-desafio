namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Console.WriteLine("");
             Console.WriteLine($"Dados do seu celular:");
              Console.WriteLine($"numero: {this.Numero}");
              Console.WriteLine($"modelo: {this.Modelo}");
              Console.WriteLine($"imei: {this.IMEI}");
              Console.WriteLine($"memoria: {this.Memoria}gb");
      
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}