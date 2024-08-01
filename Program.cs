using DesafioPOO.Models;


Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Teste", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo Teste 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");