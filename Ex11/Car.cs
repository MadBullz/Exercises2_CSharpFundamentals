using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Car
    {
        private string model;
        private int anyoFabricacion;

        public Car(string model, int anyoFabricacion)
        {
            this.model = model;
            this.anyoFabricacion = anyoFabricacion;
        }



        public string Model { get => model; set => model = value; }
        public int AnyoFabricacion { get => anyoFabricacion; set => anyoFabricacion = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Model: {model}, Year of production: {anyoFabricacion}";
        }
    }
}
