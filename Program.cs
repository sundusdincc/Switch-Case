internal class Program
{
    private static void Main(string[] args)
    {
        //Aylar
        Console.Write("Ay: ");
        int month=DateTime.Now.Month;
        switch(month)
        {
            case 1:
            Console.WriteLine("Ocak ayındasınız.!");
            break;
             case 2:
            Console.WriteLine("Şubat ayındasınız.!");
            break;
             case 3:
            Console.WriteLine("Mart ayındasınız.!");
            break;
             case 4:
            Console.WriteLine("Nisan ayındasınız.!");
            break;
             case 5:
            Console.WriteLine("Mayıs ayındasınız.!");
            break;
             case 6:
            Console.WriteLine("Haziran ayındasınız.!");
            break;
            case 7:
            Console.WriteLine("Temmuz ayındasınız.!");
            break;
            case 8:
            Console.WriteLine("Ağustos ayındasınız.!");
            break;
            case 9:
            Console.WriteLine("Eylül ayındasınız.!");
            break;
            case 10:
            Console.WriteLine("Ekim ayındasınız.!");
            break;
            case 11:
            Console.WriteLine("Kasım ayındasınız.!");
            break;
            case 12:
            Console.WriteLine("Aralık ayındasınız.!");
            break;
            
        }

        //Mevsimler
         Console.Write("Mevsim: ");
        if(month>=3 && month<=5) 
        {
            Console.WriteLine("İlkbahar mevsimindesiniz!");
        }
        else if(month>=6 && month<=8)
        {
             Console.WriteLine("Yaz mevsimindesiniz!");
             
        }
        else if(month>=9 && month<=11)
        {
             Console.WriteLine("Sonbahar mevsimindesiniz.");
             
        }
         else
        {
             Console.WriteLine("Kış mevsimindesiniz.");
             
        }
        
        //Aktivite
        Console.Write("Aktivite: ");
        switch(month)
        {
        
            case 3:
            case 4:
            case 5:
            Console.WriteLine("Longboard, scooter, rüzgar sörfü, bisiklet, fonksiyonel antrenman (functional training) gibi açık hava sporlarının yanı sıra spor salonunda yaptığınız fitness, koşu, yüzme gibi egzersizlerinizi de bahar aylarında yavaş yavaş açık havaya taşımaya başlayabilirsiniz.");
            break;
            case 6:
            case 7:
            case 8:
            Console.WriteLine("Paraşüt ile atlamayla birlikte bir düşme sanatı olarak kabul edilen skydiving ile bu yaz heyecanı ve keyfi bir arada yaşama şansı bulabilirsiniz.");
            break;
            case 9:
            case 10:
            case 11:
            Console.WriteLine("Kendinizi en yakın ormana ya da parka atıp uzunca bir yürüyüş yapmak, içinizde birikmiş enerjiyi atmak ve doğayla bir olmak için muhteşem bir mevsim değil mi sonbahar?");
            break;
            case 12:
            case 1:
            case 2:
            Console.WriteLine("Kızakla kaymak, en eğlenceli kış aktivitelerinden bir tanesidir. \n  Tıpkı yürüyüş gibi trekking de kışın neler yapılır sorusuna verilebilecek cevaplar arasındadır. ");
            break;




        }

    }
}