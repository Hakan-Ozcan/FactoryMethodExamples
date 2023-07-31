using Character;

class Program
{
    static void Main(string[] args)
    {
        // Asker yaratmak için AskerFabrikasi kullanma
        CharacterFactory soldierFactory = new SoldierFactory();
        Player soldier = soldierFactory.CreateCharacter();
        Console.WriteLine($"New character created: {soldier.Name}");
        soldier.Attack();
        soldier.ToDefend();

        Console.WriteLine();

        // Muhafız yaratmak için MuhafizFabrikasi kullanma
        CharacterFactory GuardianFactory = new GuardianFactory();
        Player guardian = GuardianFactory.CreateCharacter();
        Console.WriteLine($"New character created: {guardian.Name}");
        guardian.Attack();
        guardian.ToDefend();

        Console.WriteLine();

        // Ninja yaratmak için NinjaFabrikasi kullanma
        CharacterFactory ninjaFactory = new NinjaFactory();
        Player ninja = ninjaFactory.CreateCharacter();
        Console.WriteLine($"New character created: {ninja.Name}");
        ninja.Attack();
        ninja.ToDefend();

        Console.WriteLine();

        // Sihirbaz yaratmak için SihirbazFabrikasi kullanma
        CharacterFactory MagicianFactory = new MagicianFactory();
        Player magician = MagicianFactory.CreateCharacter();
        Console.WriteLine($"New character created: {magician.Name}");
        magician.Attack();
        magician.ToDefend();

        Console.WriteLine();

        // Zırhlı Asker yaratmak için ZirhliAskerFabrikasi kullanma
        CharacterFactory ArmoredSoldierFactory = new ArmoredSoldierFactory();
        Player armoredsoldier = ArmoredSoldierFactory.CreateCharacter();
        Console.WriteLine($"New character created: {armoredsoldier.Name}");
        armoredsoldier.Attack();
        armoredsoldier.ToDefend();
    }
}
