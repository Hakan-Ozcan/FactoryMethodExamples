// // Menü öğesi arayüzü
public interface IMenuItem
{
    void Display();
}

// Ana yemek sınıfı
public class MainCourse : IMenuItem
{
    public void Display()
    {
        Console.WriteLine("Ana yemek servisi.");
    }
}

// Tatlı sınıfı
public class Dessert : IMenuItem
{
    public void Display()
    {
        Console.WriteLine("Tatlı servisi.");
    }
}

// İçecek sınıfı
public class Beverage : IMenuItem
{
    public void Display()
    {
        Console.WriteLine("İçecek servisi.");
    }
}
public class MenuItemFactory
{
    // Yemek türlerini temsil eden enum
    public enum ItemType
    {
        MainCourse,
        Dessert,
        Beverage
    }

    // Fabrika metodu, istenen yemek türüne göre öğe oluşturacak
    public IMenuItem CreateMenuItem(ItemType type)
    {
        switch (type)
        {
            case ItemType.MainCourse:
                return new MainCourse();
            case ItemType.Dessert:
                return new Dessert();
            case ItemType.Beverage:
                return new Beverage();
            default:
                throw new ArgumentException("Geçersiz yemek türü.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen menü öğesi türünü seçin:");
        Console.WriteLine("1 - Ana Yemek");
        Console.WriteLine("2 - Tatlı");
        Console.WriteLine("3 - İçecek");

        int choice = int.Parse(Console.ReadLine());
        MenuItemFactory.ItemType selectedItemType = (MenuItemFactory.ItemType)(choice - 1);

        MenuItemFactory factory = new MenuItemFactory();
        IMenuItem menuItem = factory.CreateMenuItem(selectedItemType);

        Console.WriteLine("Seçilen menü öğesi servis ediliyor:");
        menuItem.Display();

        Console.ReadLine();
    }
}
