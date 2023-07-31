using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Araba
    {
        public abstract string ArabaTipi { get; }
        public abstract string Model { get; }
        public abstract string YakitTipi { get; }

        public void Sur()
        {
            Console.WriteLine($"Bu {ArabaTipi} arabası modeli {Model} ve yakıt tipi {YakitTipi} ile sürüşe başladı.");
        }
    }
    public class Sedan : Araba
    {
        public override string ArabaTipi => "Sedan";
        public override string Model => "Economy";
        public override string YakitTipi => "Benzin";
    }

    public class SUV : Araba
    {
        public override string ArabaTipi => "SUV";
        public override string Model => "Premium";
        public override string YakitTipi => "Dizel";
    }
    public abstract class ArabaFabrikasi
    {
        public abstract Araba ArabaUret();
    }
    public class SedanFabrikasi : ArabaFabrikasi
    {
        public override Araba ArabaUret()
        {
            return new Sedan();
        }
    }

    public class SUVFabrikasi : ArabaFabrikasi
    {
        public override Araba ArabaUret()
        {
            return new SUV();
        }
    }



}
