
using StockTrackingApp;
using StockTrackingApp.Business;
using StockTrackingApp.DataAccess;
using StokTakip.Entities;
using System;

class Program
{
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var manager = new InventoryManager(new InventoryRepository());

        // �lk veri ekleme

        if (manager.GetAllItems().Count == 0)
        {
            // Baza �r�nleri
            manager.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Kelebek", ColorCode = "K1020", Size = "160x200", QuantityInStore = 8, QuantityInShipment = 4, UnitPrice = 1800 });
            manager.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Do�ta�", ColorCode = "D4500", Size = "150x200", QuantityInStore = 6, QuantityInShipment = 2, UnitPrice = 1650 });
            manager.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Alfemo", ColorCode = "A998", Size = "180x200", QuantityInStore = 12, QuantityInShipment = 5, UnitPrice = 2100 });

            // Ba�l�k �r�nleri
            manager.AddItem(new InventoryItem { ProductName = "Ba�l�k", Brand = "Mondihome", ColorCode = "M325", Size = "160x200", QuantityInStore = 20, QuantityInShipment = 6, UnitPrice = 1900 });
            manager.AddItem(new InventoryItem { ProductName = "Ba�l�k", Brand = "�pek", ColorCode = "I850", Size = "180x200", QuantityInStore = 14, QuantityInShipment = 3, UnitPrice = 1750 });
            manager.AddItem(new InventoryItem { ProductName = "Ba�l�k", Brand = "Enza", ColorCode = "E452", Size = "150x200", QuantityInStore = 10, QuantityInShipment = 4, UnitPrice = 1850 });

            // Yatak �r�nleri
            manager.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Bambi", ColorCode = "Y789", Size = "160x200", QuantityInStore = 9, QuantityInShipment = 3, UnitPrice = 1300 });
            manager.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Yatsan", ColorCode = "YT12", Size = "180x200", QuantityInStore = 11, QuantityInShipment = 2, UnitPrice = 1450 });
            manager.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Visco", ColorCode = "V525", Size = "150x200", QuantityInStore = 7, QuantityInShipment = 1, UnitPrice = 1600 });
        }



        Application.Run(new Form1(manager));

    }
}