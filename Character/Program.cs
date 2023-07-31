using Character;

class Program
{
    static void Main(string[] args)
    {
        // Asker yaratmak için AskerFabrikasi kullanma
        KarakterFabrikasi askerFabrikasi = new AskerFabrikasi();
        Oyuncu asker = askerFabrikasi.KarakterYarat();
        Console.WriteLine($"Yeni karakter oluşturuldu: {asker.Ad}");
        asker.Saldir();
        asker.Savun();

        Console.WriteLine();

        // Muhafız yaratmak için MuhafizFabrikasi kullanma
        KarakterFabrikasi muhafizFabrikasi = new MuhafizFabrikasi();
        Oyuncu muhafiz = muhafizFabrikasi.KarakterYarat();
        Console.WriteLine($"Yeni karakter oluşturuldu: {muhafiz.Ad}");
        muhafiz.Saldir();
        muhafiz.Savun();

        Console.WriteLine();

        // Ninja yaratmak için NinjaFabrikasi kullanma
        KarakterFabrikasi ninjaFabrikasi = new NinjaFabrikasi();
        Oyuncu ninja = ninjaFabrikasi.KarakterYarat();
        Console.WriteLine($"Yeni karakter oluşturuldu: {ninja.Ad}");
        ninja.Saldir();
        ninja.Savun();

        Console.WriteLine();

        // Sihirbaz yaratmak için SihirbazFabrikasi kullanma
        KarakterFabrikasi sihirbazFabrikasi = new SihirbazFabrikasi();
        Oyuncu sihirbaz = sihirbazFabrikasi.KarakterYarat();
        Console.WriteLine($"Yeni karakter oluşturuldu: {sihirbaz.Ad}");
        sihirbaz.Saldir();
        sihirbaz.Savun();

        Console.WriteLine();

        // Zırhlı Asker yaratmak için ZirhliAskerFabrikasi kullanma
        KarakterFabrikasi zirhliAskerFabrikasi = new ZirhliAskerFabrikasi();
        Oyuncu zirhliAsker = zirhliAskerFabrikasi.KarakterYarat();
        Console.WriteLine($"Yeni karakter oluşturuldu: {zirhliAsker.Ad}");
        zirhliAsker.Saldir();
        zirhliAsker.Savun();
    }
}
