
using StockTrackingApp.Business;
using StockTrackingApp.DataAccess;
using StokTakip.Entities;
using System;

class Program
{
    static void Main()
    {
        var manager = new InventoryManager(new InventoryRepository());

        // Ýlk veri ekleme
        if (manager.GetAllItems().Count == 0)
        {
            manager.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Ýstikbal", ColorCode = "Brown", Size = "180x200", QuantityIn = 10, QuantityOut = 3, UnitPrice = 1500 });
            manager.AddItem(new InventoryItem { ProductName = "Baþlýk", Brand = "Sümer", ColorCode = "White", Size = "180x200", QuantityIn = 15, QuantityOut = 5, UnitPrice = 2000 });
            manager.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Yataþ", ColorCode = "Brown", Size = "180x50", QuantityIn = 7, QuantityOut = 2, UnitPrice = 800 });
        }

        // Listeleme
        foreach (var item in manager.GetAllItems())
        {
            Console.WriteLine($"{item.ProductName} | Stock: {item.CurrentStock} | Total: {item.TotalPrice:C}");
        }
    }
}