using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public abstract class Player
    {
        public abstract string Name { get; }
        public abstract void Attack();
        public abstract void ToDefend();
    }
    public class Soldier : Player
    {
        public override string Name => "Soldier";

        public override void Attack()
        {
            Console.WriteLine("Soldier attacking!");
        }

        public override void ToDefend()
        {
            Console.WriteLine("Soldier defending!");
        }
    }
    public class Guardian : Player
    {
        public override string Name => "Muhafız";

        public override void Attack()
        {
            Console.WriteLine("Guardian attacking!");
        }

        public override void ToDefend()
        {
            Console.WriteLine("Guardian defending!");
        }
    }
    public class Ninja : Player
    {
        public override string Name => "Ninja";

        public override void Attack()
        {
            Console.WriteLine("Ninja attacking!");
        }

        public override void ToDefend()
        {
            Console.WriteLine("Ninja defending!");
        }
    }
    public class Magician : Player
    {
        public override string Name => "Magician";

        public override void Attack()
        {
            Console.WriteLine("Magician attacking!");
        }

        public override void ToDefend()
        {
            Console.WriteLine("Magician defending!");
        }
    }
    public class ArmoredSoldier : Player
    {
        public override string Name => "Armored Soldier";

        public override void Attack()
        {
            Console.WriteLine("Armored Soldier attacking!");
        }

        public override void ToDefend()
        {
            Console.WriteLine("Armored Soldier defending!");
        }
    }
}
