using DesafioPOO.Models;

Nokia smartphoneNokia = new("419965434", "axo098", "000000000000", 128);
Console.WriteLine("Nokia:");
smartphoneNokia.Ligar();
smartphoneNokia.ReceberLigacao();
smartphoneNokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");

Smartphone iphone = new Iphone("417555376", "17 pro Max", "21212121", 256);
Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
