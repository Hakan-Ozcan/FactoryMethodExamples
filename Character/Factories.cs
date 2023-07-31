using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public abstract class CharacterFactory
    {
        public abstract Player CreateCharacter();
    }
    public class SoldierFactory : CharacterFactory
    {
        public override Player CreateCharacter()
        {
            return new Soldier();
        }
    }
    public class GuardianFactory : CharacterFactory
    {
        public override Player CreateCharacter()
        {
            return new Guardian();
        }
    }
    // Somut yaratıcı sınıf - NinjaFabrikasi
    public class NinjaFactory : CharacterFactory
    {
        public override Player CreateCharacter()
        {
            return new Ninja();
        }
    }

    // Somut yaratıcı sınıf - SihirbazFabrikasi
    public class MagicianFactory : CharacterFactory
    {
        public override Player CreateCharacter()
        {
            return new Magician();
        }
    }

    // Somut yaratıcı sınıf - ZirhliAskerFabrikasi
    public class ArmoredSoldierFactory : CharacterFactory
    {
        public override Player CreateCharacter()
        {
            return new ArmoredSoldier();
        }
    }

}
