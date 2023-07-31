using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public abstract class Oyuncu
    {
        public abstract string Ad { get; }
        public abstract void Saldir();
        public abstract void Savun();
    }
    public class Asker : Oyuncu
    {
        public override string Ad => "Asker";

        public override void Saldir()
        {
            Console.WriteLine("Asker saldırıyor!");
        }

        public override void Savun()
        {
            Console.WriteLine("Asker savunuyor!");
        }
    }
    public class Muhafiz : Oyuncu
    {
        public override string Ad => "Muhafız";

        public override void Saldir()
        {
            Console.WriteLine("Muhafız saldırıyor!");
        }

        public override void Savun()
        {
            Console.WriteLine("Muhafız savunuyor!");
        }
    }
    public class Ninja : Oyuncu
    {
        public override string Ad => "Ninja";

        public override void Saldir()
        {
            Console.WriteLine("Ninja saldırıyor!");
        }

        public override void Savun()
        {
            Console.WriteLine("Ninja savunuyor!");
        }
    }
    public class Sihirbaz : Oyuncu
    {
        public override string Ad => "Sihirbaz";

        public override void Saldir()
        {
            Console.WriteLine("Sihirbaz saldırıyor!");
        }

        public override void Savun()
        {
            Console.WriteLine("Sihirbaz savunuyor!");
        }
    }
    public class ZirhliAsker : Oyuncu
    {
        public override string Ad => "Zırhlı Asker";

        public override void Saldir()
        {
            Console.WriteLine("Zırhlı Asker saldırıyor!");
        }

        public override void Savun()
        {
            Console.WriteLine("Zırhlı Asker savunuyor!");
        }
    }
}
