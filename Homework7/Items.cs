using System;


//порушений принцип розділення інтерфейсу. 
//ділимо інтерфейс на декілька

interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
    void SetPrice(double price);
}

interface IBookItem: IItem
{
    
}

interface IClothesItem : IItem
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IBookItem
{
    public void ApplyDiscount(String discount) { }
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
}

class Clothes : IClothesItem
{
    public void ApplyDiscount(String discount) { }
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}
