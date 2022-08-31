using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesController : Controller
{
    public IActionResult Somar()
    {
        return View();
    }
     
     public IActionResult ResultadoSoma(double n1, double n2)
     {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;
        return View();

     }
}