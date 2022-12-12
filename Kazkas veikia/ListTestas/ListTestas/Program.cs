using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Item> items = new List<Item>();
        for (int i=0; i<=5; i++) {
            items.AddAlso(new Item { Id = i, Price = 10, Description = "Test", Sold=false });
        }
        foreach (var item in items)
            Console.WriteLine("Id {0} Name {1}, Description {2}, Sold: {3}", item.Id, item.Price, item.Description, item.Sold);
    }

}

public static class Extensions
{
    public static List<T> AddAlso<T>(this List<T> list, T item)
    {
        list.Add(item);
        return list;
    }
}


public class Item
{
    public int Id { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public Boolean Sold { get; set; }

    public Item()
    {
        Price = 10;
        Description = "testas";
        Sold = false;
    }

 
}

