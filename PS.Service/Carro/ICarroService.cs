using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service.Carro
{
    public interface ICarroService
    {
        List<Model.Entities.Carro.Carro> GetCarros();
    }
}
