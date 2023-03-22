using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class ShoppingCart
    {
        // ---------------- Attributes ----------------
        private Product[] _products;
        private double _total;

        // ---------------- Constructor ----------------
        public ShoppingCart()
        {
            _products = new Product[] {};
            _total = 0;
        }

        // ---------------- Getters ----------------
        public Product[] Products { get { return _products; } }
        public double Total { get { return _total; } }

        // ---------------- Methods ----------------
        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, (_products.Length + 1));
            _products[_products.Length - 1] = product;
            _total = CalculateTotal();
        }

        public void RemoveProduct(Product product)
        {
            int numIndex = Array.IndexOf(Products, product);
            _products = Products.Where((val, idx) => idx != numIndex).ToArray();
        }

        internal double CalculateTotal()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.Price;
            }
            return total;
        }

        public void Show()
        {
            Console.WriteLine("\t Productos en el Carrito:");
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Products[i].Name} con un costo de {Products[i].Price}$");
            }
            Console.WriteLine($"\nEl carrito da un total de {Total}$");
        }
    }
}
