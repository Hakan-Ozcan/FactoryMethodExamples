using Car;

class Program
{
    static void Main(string[] args)
    {
        ArabaFabrikasi sedanFabrikasi = new SedanFabrikasi();
        Araba sedanAraba = sedanFabrikasi.ArabaUret();
        sedanAraba.Sur();

        ArabaFabrikasi suvFabrikasi = new SUVFabrikasi();
        Araba suvAraba = suvFabrikasi.ArabaUret();
        suvAraba.Sur();
    }
}
