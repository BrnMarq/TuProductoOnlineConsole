using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuProductoOnline
{
    public class Catalogue
    {
        // ---------------- Attributes ----------------
        private Software[] _softwareProducts;
        private Hardware[] _hardwareProducts;
        private Devices[] _deviceProducts;

        // ---------------- Constructor ----------------
        public Catalogue()
        {
            _softwareProducts = new Software[] { };
            _hardwareProducts = new Hardware[] { };
            _deviceProducts = new Devices[] { };
        }

        // ---------------- Getters ----------------
        public Software[] SoftwareProducts { get { return _softwareProducts; } }
        public Hardware[] HardwareProducts { get { return _hardwareProducts; } }
        public Devices[] DeviceProducts { get { return _deviceProducts; } }

        // ---------------- Methods ----------------
        public void AddSoftwareProduct(Software product)
        {
            Array.Resize(ref _softwareProducts, (_softwareProducts.Length + 1));
            _softwareProducts[_softwareProducts.Length - 1] = product;
        }

        public void AddHardwareProduct(Hardware product)
        {
            Array.Resize(ref _hardwareProducts, (_hardwareProducts.Length + 1));
            _hardwareProducts[_hardwareProducts.Length - 1] = product;
        }

        public void AddDeviceProduct(Devices product)
        {
            Array.Resize(ref _deviceProducts, (_deviceProducts.Length + 1));
            _deviceProducts[_deviceProducts.Length - 1] = product;
        }
    }
}
