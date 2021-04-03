using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS.Service.Carro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Web.Controllers.Carro
{

    public class CarroController : Controller
    {
        //private readonly ICarroService _carroService;

        public ActionResult ConsultaCarro()
        {
            return View("ConsultaCarro");
        } 
    }
}
