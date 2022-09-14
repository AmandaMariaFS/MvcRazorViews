using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = 
        new List<EstudanteViewModel>{
            new EstudanteViewModel(1, "Ana da Silva", "Rua A, n 11", true),
            new EstudanteViewModel(2, "Karina Oliveira", "Rua K, n 11", false),
            new EstudanteViewModel(3, "Amanda Maria", "Rua Am, n 11", true)
        };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
       // var estudante = new EstudanteViewModel(5, "Lucas", "Rua L, n 11", true);
        return View(estudantes[id-1]);
    }
}