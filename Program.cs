using DesafioPOO.Models;
Console.WriteLine("Smartphone: Iphone");
Smartphone iphone = new Iphone(numero:"514",Modelo:"2025 - IP25",IMEI:"AL227H",Memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();
Console.WriteLine("Smartphone: Nokia");
Smartphone nokia = new Nokia(numero:"222239",Modelo:"09lk25",IMEI:"NK000",Memoria:64);
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();