using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Model.Entities.Carro
{
    public class Carro : AEntity<int>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }
        public bool EstaDentro { get; set; }

    }
}
