using System;

//Порушений принцип підстановки Лісков
/* 
 * Тепер прямокутник та квадрат залежать від абстрактного
 * геометричного об'єкту, де єдина спільна властивість - існування площі
 */
abstract class GeometricObject
{
    public abstract int GetArea();
}

class Rectangle : GeometricObject
{
    public int Width { get; set; }
    public int Height { get; set; }
    
    public override int GetArea()
    {
        return Width * Height;
    }
}

class Square : GeometricObject
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}


class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetArea());
            Console.ReadKey();
        }
    }