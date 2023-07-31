using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public abstract class KarakterFabrikasi
    {
        public abstract Oyuncu KarakterYarat();
    }
    public class AskerFabrikasi : KarakterFabrikasi
    {
        public override Oyuncu KarakterYarat()
        {
            return new Asker();
        }
    }
    public class MuhafizFabrikasi : KarakterFabrikasi
    {
        public override Oyuncu KarakterYarat()
        {
            return new Muhafiz();
        }
    }
    // Somut yaratıcı sınıf - NinjaFabrikasi
    public class NinjaFabrikasi : KarakterFabrikasi
    {
        public override Oyuncu KarakterYarat()
        {
            return new Ninja();
        }
    }

    // Somut yaratıcı sınıf - SihirbazFabrikasi
    public class SihirbazFabrikasi : KarakterFabrikasi
    {
        public override Oyuncu KarakterYarat()
        {
            return new Sihirbaz();
        }
    }

    // Somut yaratıcı sınıf - ZirhliAskerFabrikasi
    public class ZirhliAskerFabrikasi : KarakterFabrikasi
    {
        public override Oyuncu KarakterYarat()
        {
            return new ZirhliAsker();
        }
    }

}
