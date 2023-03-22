using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Devices: Product
    {
        // ---------------- Attributes ----------------
        private string _model;

        // ---------------- Constructor ----------------
        public Devices(string name, double price, string brand, string description, string model) : base(name, price, brand, description)
        {
            _model = model;
        }

        // ---------------- Getters & Setters ----------------
        public string Model { get { return _model; } set { _model = value; } }

        // ---------------- Methods ----------------
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Modelo: {Model}");
        }

        public static void InitializeProducts(Catalogue catalogue)
        {
            int productsAmount = 5;

            string[] names = { "Teclado", "Mouse", "Auriculares", "Audífonos", "Webcam" };
            int[] prices = { 74, 35, 150, 39, 90 };
            string[] brands = { "Keychron", "Redragon", "Sony", "Xiaomi", "ElGato" };
            string[] descriptions = {
                "En informática, un teclado es un dispositivo de entrada, en parte inspirado en el teclado de las máquinas de escribir, que utiliza un sistema de puntadas o márgenes",
                "El ratón o mouse es un dispositivo apuntador utilizado para facilitar el manejo de un entorno gráfico en una computadora.",
                "Los auriculares se conectan a través de un teléfono oa una computadora, lo que permite al usuario hablar y escuchar mientras mantiene ambas manos libres.",
                "Aparato que consta de dos piezas con unos dispositivos capaces de transformar ondas eléctricas en ondas sonoras y que, unidas por una tira generalmente curva y ajustable a la cabeza, se acoplan a los oídos para la recepción del sonido.",
                "Cámara de vídeo miniaturizada que se puede conectar a un ordenador para grabar imágenes o emitirlas en directo a través de Internet."
            };
            string[] models = { "K2", "MDR300", "3000", "M9", "Pro" };

            for (int i = 0; i < productsAmount; i++)
            {
                Devices device = new Devices(names[i], prices[i], brands[i], descriptions[i], models[i]);
                catalogue.AddDeviceProduct(device);
            }
        }
    }
}
