// See h// Şekil arayüzü
using Microsoft.Win32.SafeHandles;

public interface IShape
{
    void Draw();
}

// Dikdörtgen sınıfı
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Rectangle drawn.");
    }
}

// Daire sınıfı
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Circle drawn.");
    }
}
public class ShapeFactory
{
    // Şekil türlerini temsil eden enum
    public enum ShapeType
    {
        Rectangle,
        Circle
    }

    // Fabrika metodu, istenen şekli oluşturacak
    public IShape CreateShape(ShapeType type)
    {
        switch (type)
        {
            case ShapeType.Rectangle:
                return new Rectangle();
            case ShapeType.Circle:
                return new Circle();
            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select the type of shape you want to draw:");
        Console.WriteLine("1 - Rectangle");
        Console.WriteLine("2 - Circle");

        int choice = int.Parse(Console.ReadLine());
      
        ShapeFactory.ShapeType selectedShape = (ShapeFactory.ShapeType)(choice - 1);

        ShapeFactory factory = new ShapeFactory();
        IShape shape = factory.CreateShape(selectedShape);

        Console.WriteLine("We draw the selected shape:");
        shape.Draw();//sırf burda türünü belirtmeden genel olarak draw diyebilmek için önceki işlemler yapıldı

        Console.ReadLine();
    }
}


