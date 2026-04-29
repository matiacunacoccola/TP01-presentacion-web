using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01_presentacion_web.Models;

namespace TP01_presentacion_web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    Grupo grupo = new Grupo();

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
    var i = grupo.Buscar(dni);

    if (i == null)
        return RedirectToAction("Index");

    ViewBag.Integrante = i;
    return View("infoIntegrante");
}}