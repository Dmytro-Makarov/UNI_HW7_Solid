using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/
//Очевидно, принцип розділення інтерфейсу
interface IPrice
{
    void SetPrice(double price);
}

interface ISize
{
    void SetSize(byte size);
}

interface IColor
{
    void SetColor(byte color);
}

interface IDiscount
{
    void ApplyDiscount(String discount);
}

interface IPromocode
{
    void ApplyPromocode(String promocode);
}

class Book : IPrice, IDiscount
{
    private double price;
    private string discount;
    
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
    }

    public void GetBook()
    {
        Console.WriteLine("Book");
        Console.WriteLine("Price:" + price);
        Console.WriteLine("Discount:" + discount);
    }
}

class Clothes : IPrice, IDiscount, ISize, IColor
{
    private double price;
    private string discount;
    private byte size;
    private byte color;
    
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
    }

    public void SetSize(byte size)
    {
        this.size = size;
    }

    public void SetColor(byte color)
    {
        this.color = color;
    }

    public void GetClothes()
    {
        Console.WriteLine("Clothes");
        Console.WriteLine("Price:" + price);
        Console.WriteLine("Discount:" + discount);
        Console.WriteLine("Size:" + size);
        Console.WriteLine("Color:" + color);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var book = new Book();
        book.SetPrice(1);
        book.ApplyDiscount("1%");
        book.GetBook();

        var clothes = new Clothes();
        clothes.SetPrice(2);
        clothes.SetColor(0);
        clothes.SetSize(3);
        clothes.GetClothes();
        Console.ReadKey();
    }
}