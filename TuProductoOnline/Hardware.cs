using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Hardware: Product
    {
        // ---------------- Attributes ----------------
        private string _dimensions;

        // ---------------- Constructor ----------------
        public Hardware(string name, double price, string brand, string description, string dimensions): base(name, price, brand, description)
        {
            _dimensions = dimensions;
        }

        // ---------------- Getters & Setters ----------------
        public string Dimensions { get { return _dimensions; } set { _dimensions = value; } }

        // ---------------- Methods ----------------
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Las dimensiones son: {Dimensions}");
        }

        public static void InitializeProducts(Catalogue catalogue)
        {
            int productsAmount = 5;

            string[] names = { "Disco duro SSD", "Tarjeta madre", "Memoria RAM", "CPU", "Fuente de alimentación" };
            int[] prices = { 30, 500, 80, 15, 17 };
            string[] brands = { "Kingston", "ASUS", "Corsair", "Intel", "Seasonic" };
            string[] descriptions = {
                "Lugar de almacenamiento de un ordenador",
                "Se encarga la comunicación de datos, el control y el monitoreo, la administración o la gestión de la energía eléctrica así como la distribución de la misma por todo el computador, la conexión física de los diversos componentes del citado y, por supuesto, la temporización y el sincronismo.",
                "Su función principal es recordar la información que tienes en cada una de las aplicaciones abiertas en el computador, mientras este se encuentre encendido. Esta memoria de corto plazo solo actúa cuando el computador esté encendido.",
                "Se encarga de procesar todas las instrucciones del dispositivo, leyendo las órdenes y requisitos del sistema operativo, así como las instrucciones de cada uno de los componentes y las aplicaciones",
                "dispositivo que convierte la corriente alterna, en una o varias corrientes continuas, que alimentan los distintos circuitos del aparato electrónico al que se conecta."
            };
            string[] dimensions = { "10cm x 28cm", "30,5 cm x 33 cm.", "13.3 cm. X 3.1 x 1 mm", "55 cm x 22 cm", "140 x 150 x 85 mm" };

            for (int i = 0; i < productsAmount; i++)
            {
                Hardware hardware = new Hardware(names[i], prices[i], brands[i], descriptions[i], dimensions[i]);
                catalogue.AddHardwareProduct(hardware);
            }
        }
    }
}
