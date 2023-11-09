using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
 Nokia nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1112233", memoria: 128);
 nokia.Ligar();
 nokia.ReceberLigacao();
 nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "1112233", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");