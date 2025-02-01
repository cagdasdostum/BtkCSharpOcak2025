using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_uygulamam.Models;

namespace web_uygulamam.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Kisiler()
    {
        Db baglanti = new();
        List<Kisi> liste = baglanti.Kisiler.ToList();

        return View(liste);//bu liste View sayfasına Model olarak gider
    }
    public IActionResult YeniKisi()
    {
        return View();
    }

    [HttpPost]
    public IActionResult YeniKisi(Kisi yeniKisi)
    {
       Db baglanti = new();
       baglanti.Kisiler.Add(yeniKisi);
       baglanti.SaveChanges();

       return RedirectToAction("Kisiler");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
