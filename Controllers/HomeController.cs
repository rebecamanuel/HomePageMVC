using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetoNovo.Models;

namespace projetoNovo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
{
    List<Produto> produtos = new List<Produto>
{
    new Produto("Computador",1, 750),
    new Produto("Rato", 2, 15),
    new Produto("Teclado", 3, 30),
    new Produto("Monitor", 4, 180),
    new Produto("Impressora", 5, 120)
};


    return View(produtos);
}

   public IActionResult Mulheres()
        {
            return View();
        } 

    public IActionResult Areas()
    {
        return View();
    }

    public IActionResult Futuro()
    {
        return View();
    }

    /*public IActionResult Privacy()
    {
        return View();
    } */

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
