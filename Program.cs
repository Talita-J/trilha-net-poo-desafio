using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Nokia1", imei: "11111111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Zap");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "680000", modelo: "Iphone 14 Pro Max", imei: "9294858", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
