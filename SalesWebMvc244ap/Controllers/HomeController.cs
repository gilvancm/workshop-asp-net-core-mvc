using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMvc244ap.Models;

namespace SalesWebMvc244ap.Controllers
{
    public class HomeController : Controller
    {
        // todo HomeController herda da classe Controller ou uma subclasse de controle
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //todos retornão um objeto do tipo IActionResult e ação index()
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()   //IActionResult é uma interfase generica
        {
            //o ViewDate é um dicionário que leve uma coleção de pares valores
            //objeto ViewDate   o ["message"] é a chave
            ViewData["message"] = "Salles web MVC App from C# Course ";
            ViewData["professor"] = "Nelio Alves";
            ViewData["email"] = "nelioalves@gmail.com";

            //esse View() é o que chamamos de Method builder
            return View();  //vc com controu espaço vc seleciona os tipo e metodos
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
