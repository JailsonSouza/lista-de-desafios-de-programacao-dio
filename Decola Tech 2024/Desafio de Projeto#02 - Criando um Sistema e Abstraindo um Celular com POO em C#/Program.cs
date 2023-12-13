using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("----------------------------------------");
Console.WriteLine("Testes no Smartphone NOKIA");
Console.WriteLine("----------------------------------------");
Smartphone tel_nokia = new Nokia(numero: "88 99887766", modelo: "G11 Plus", imei: "00112233", memoria: 32);
tel_nokia.Ligar();
tel_nokia.ReceberLigacao();
tel_nokia.InstalarAplicativo("Instagram");

Console.WriteLine("----------------------------------------");
Console.WriteLine("Testes no Smartphone iPhone");
Console.WriteLine("----------------------------------------");
Smartphone tel_iphone = new Iphone(numero: "88 66778899", modelo: "15 PRO", imei: "00332211", memoria: 256);
tel_iphone.Ligar();
tel_iphone.ReceberLigacao();
tel_iphone.InstalarAplicativo("Linkedin");
Console.WriteLine("----------------------------------------");