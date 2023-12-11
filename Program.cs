using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");