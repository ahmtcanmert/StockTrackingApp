using StockTrackingApp;
using StockTrackingApp.Businiess.Manager;
using StokTakip.Entities;
using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        // WinForms ayarlarý
        System.Windows.Forms.Application.EnableVisualStyles();
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

        // Servis manager oluþtur
        var manager = new ServiceManager();

        // Ýlk veri ekleme
        if (manager.InventoryService.GetAllItems().Count == 0)
        {
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Kelebek", ColorCode = "K1020", Size = "160x200", QuantityInStore = 8, QuantityInShipment = 4, UnitPrice = 1800 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Doðtaþ", ColorCode = "D4500", Size = "150x200", QuantityInStore = 6, QuantityInShipment = 2, UnitPrice = 1650 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baþlýk", Brand = "Enza", ColorCode = "E452", Size = "150x200", QuantityInStore = 10, QuantityInShipment = 4, UnitPrice = 1850 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Bambi", ColorCode = "Y789", Size = "160x200", QuantityInStore = 9, QuantityInShipment = 3, UnitPrice = 1300 });

            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baþlýk", Brand = "Mondihome", ColorCode = "M325", Size = "160x200", QuantityInStore = 20, QuantityInShipment = 6, UnitPrice = 1900 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baþlýk", Brand = "Ýpek", ColorCode = "I850", Size = "180x200", QuantityInStore = 14, QuantityInShipment = 3, UnitPrice = 1750 });

            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Yatsan", ColorCode = "YT12", Size = "180x200", QuantityInStore = 11, QuantityInShipment = 2, UnitPrice = 1450 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Baza", Brand = "Alfemo", ColorCode = "A998", Size = "180x200", QuantityInStore = 12, QuantityInShipment = 5, UnitPrice = 2100 });
            manager.InventoryService.AddItem(new InventoryItem { ProductName = "Yatak", Brand = "Visco", ColorCode = "V525", Size = "150x200", QuantityInStore = 7, QuantityInShipment = 1, UnitPrice = 1600 });
        }

        // Ana formu çalýþtýr
        System.Windows.Forms.Application.Run(new MainForm(manager));
    }
}
