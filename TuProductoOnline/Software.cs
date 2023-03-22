using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Software : Product
    {
        // ---------------- Attributes ----------------
        private string _license;

        // ---------------- Constructor ----------------
        public Software(string name, double price, string brand, string description, string license) : base(name, price, brand, description)
        {
            _license = license;
        }

        // ---------------- Getters & Setters ----------------
        public string License { get { return _license; } set { _license = value; } }

        // ---------------- Methods ----------------
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Licencia: {License}");
        }

        public static void InitializeProducts(Catalogue catalogue)
        {
            int productsAmount = 5;

            string[] names = { "VSCode", "Ubuntu", "League Of Legends", "Advanced System Care", "WinRAR" };
            int[] prices = { 10, 20, 1000, 15, 17 };
            string[] brands = { "Microsoft", "Software Libre", "Riot Games", "IOBit", "Eugene Roshal" };
            string[] descriptions = { 
                "Programa para editar código",
                "Sistema Operativo basado en UNIX flexible y ligero",
                "Juego estilo MOBA con una gran cantidad de jugadores activos",
                "Programa para optimizar el funcionamiento del ordenador",
                "Programa para descomprimir archivos comprimidos, con mayor uso en los formatos de tipo .rar"
            };
            string[] licenses = { "Free", "Free", "Riot License", "MIT", "rarreg" };

            for (int i = 0; i < productsAmount; i++)
            {
                Software software = new Software(names[i], prices[i], brands[i], descriptions[i], licenses[i]);
                catalogue.AddSoftwareProduct(software);
            }
        }
    }
}
