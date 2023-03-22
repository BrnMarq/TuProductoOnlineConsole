using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Bill
    {
        // ---------------- Attributes ----------------
        private ShoppingCart _shoppingCart;
        private string _firstName;
        private string _lastName;
        private string _dni;

        // ---------------- Constructor ----------------
        public Bill(ShoppingCart shoppingCart, string firstName, string lastName, string dni)
        {
            _shoppingCart = shoppingCart;
            _firstName = firstName;
            _lastName = lastName;
            _dni = dni;
        }

        // ---------------- Getters ----------------
        public ShoppingCart ShoppingCart { get { return _shoppingCart; } }
        public string FirstName { get { return _firstName;} }
        public string LastName { get { return _lastName;} }
        public string Dni { get { return _dni; } }

        // ---------------- Methods ----------------
        public void Show()
        {
            Console.WriteLine("Gracias por completar su compra!");
            Console.WriteLine($"Facturado a nombre de {FirstName} {LastName}");
            Console.WriteLine($"CI: {Dni}");
            Console.WriteLine("Productos:");
            foreach (Product product in ShoppingCart.Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price}$");
            }
            Console.WriteLine($"Por un total de: {ShoppingCart.Total}$");
        }
    }
}
