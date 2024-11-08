using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"47988888888", modelo:"16proMax", imei:"987523451", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero:"4799999999", modelo:"2280", imei:"63210765845", memoria:8);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");