using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Menu
    {
        // ---------------- Attributes ----------------
        Catalogue _catalogue;
        ShoppingCart _shoppingCart;

        // ---------------- Constructor ----------------
        public Menu()
        {
            _shoppingCart = new ShoppingCart();
            _catalogue = new Catalogue();

            Software.InitializeProducts(_catalogue);
            Hardware.InitializeProducts(_catalogue);
            Devices.InitializeProducts(_catalogue);
        }

        // ---------------- Getters ----------------
        public Catalogue Catalogue { get { return _catalogue; } }
        public ShoppingCart ShoppingCart { get { return _shoppingCart; } }

        // ---------------- Methods ----------------
        public void MainMenu()
        {
            int option = -1;
            while (option != 5)
            {
                GeneralMenu();
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                if (option == 1) ProductsMenu(Catalogue.HardwareProducts, "Dispositivos de Hardware");
                if (option == 2) ProductsMenu(Catalogue.SoftwareProducts, "Programas disponibles");
                if (option == 3) ProductsMenu(Catalogue.DeviceProducts, "Dispositivos Electrónicos");
                if (option == 4) ShoppingCartMenu();
            }
        }

        public void GeneralMenu()
        {
            Wrapper();
            Console.WriteLine("\t TuProductoOnline");
            Console.WriteLine("1. Ver catálogo de Hardware");
            Console.WriteLine("2. Ver catálogo de Software");
            Console.WriteLine("3. Ver catálogo de Dispositivos Electrónicos");
            Console.WriteLine("4. Revisar Carrito de Compras");
            Console.WriteLine("5. Salir");
            Wrapper();
        }

        // ---------------- Product Menus ----------------
        public void ProductsMenu(Product[] products, string title)
        {
            Wrapper();
            Console.WriteLine($"\t {title}");
            int productsLength = products.Length;
            for (int i = 0; i < productsLength; i++)
            {
                Console.WriteLine($"{i + 1} - {products[i].Name}");
            }
            Wrapper();
            Console.WriteLine($"{productsLength + 1} - Volver atrás");
            Wrapper();
            int catalogueOption = int.Parse(Console.ReadLine());
            if (catalogueOption > 0 && catalogueOption < 6)
            {
                ProductDetail(products[catalogueOption - 1]);
            }
            Console.Clear();
        }

        public void ProductDetail(Product product)
        {
            Wrapper();
            product.Show();
            Wrapper();
            Console.WriteLine("Desea comprar el producto?");
            Console.WriteLine("1 - Sí");
            Console.WriteLine("2 - No");
            int addProduct = int.Parse(Console.ReadLine());
            Console.Clear();
            if (addProduct == 1) ShoppingCart.AddProduct(product);
        }

        // ---------------- Shopping Cart Menus ----------------
        public void ShoppingCartMenu()
        {
            Wrapper();
            Console.WriteLine("1 - Ver artículos del carrito");
            Console.WriteLine("2 - Eliminar artículos del carrito");
            Console.WriteLine("3 - Facturar");
            Console.WriteLine("4 - Volver");

            Wrapper();
            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if (option == 1) ShoppingCart.Show();
            if (option == 2) DeleteItemMenu();
            if (option == 3) BillMenu();
            Console.ReadLine();
            Console.Clear();
        }

        public void DeleteItemMenu()
        {
            ShoppingCart.Show();
            Console.WriteLine("Escoja el item que desea eliminar, si no quiere eliminar ninguno, ingrese 0");
            int itemToDelete = int.Parse(Console.ReadLine());
            if (itemToDelete > 0 && itemToDelete < ShoppingCart.Products.Length + 1)
            {
                ShoppingCart.RemoveProduct(ShoppingCart.Products[itemToDelete - 1]);
            }
            Console.WriteLine("Se eliminó el producto del carrito de compras exitósamente!");
        }

        public void BillMenu()
        {
            Console.WriteLine("Ingrese su Nombre:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese su Cédula de Identidad:");
            string dni = Console.ReadLine();

            Bill bill = new Bill(ShoppingCart, firstName, lastName, dni);
            _shoppingCart = new ShoppingCart();
            bill.Show();
        }

        // ---------------- Helpers ----------------
        public void Wrapper()
        {
            Console.WriteLine("-------------------------------------------");
        }
    }
}
