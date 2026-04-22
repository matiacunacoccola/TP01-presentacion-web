using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01_presentacion_web.Models;

namespace TP01_presentacion_web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
     public IActionResult Index()
    {
        ViewBag.Lista = grupo.Devolver();
        return View();
    }

    public IActionResult SelectIntegrante(int dni)
    {
        ViewBag.Integrante = grupo.Buscar(dni);
        return View("infoIntegrante");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    
}
