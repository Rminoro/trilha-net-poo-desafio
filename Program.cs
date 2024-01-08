// Teste com as classes Nokia e Iphone
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("123456789", "Nokia 8", "Nokia");
        Iphone iphone = new Iphone("987654321", "iPhone 12", "Apple");

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}