using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service.Carro
{
    public class CarroService
    {
       
        public CarroService(){}

        public List<Model.Entities.Carro.Carro> GetCarros()
        {
            return new List<Model.Entities.Carro.Carro>()
            {
                new Model.Entities.Carro.Carro()
                {
                    Id = 1,
                    Marca = "VW",
                    Modelo = "Beetle",
                    Color = "Trucho",
                    Placa = "A4206969"
                },

                new Model.Entities.Carro.Carro()
                {
                    Id = 1,
                    Marca = "VW",
                    Modelo = "Jetta",
                    Color = "Trucho",
                    Placa = "A4206968"
                }
            };
        }
    }
}
