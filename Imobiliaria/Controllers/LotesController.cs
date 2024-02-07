using Imobiliaria.Models;
using Imobiliaria.Service;
using Microsoft.AspNetCore.Mvc;

namespace Imobiliaria.Controllers;

public class LotesController : Controller
{
    //instanciando injeção de dependencia de LoteService e CLienteService
    private readonly LoteService _loteService;
    private readonly ClienteService _clienteService;

    //Contrutor passando LoteService e ClienteService como argumento, Também é configurado o builder.Service.AddScoped<LoteService> e builder.Service.AddScoped<ClienteService> no arquivo program
    public LotesController(LoteService loteService, ClienteService clienteService)
    {
        _loteService = loteService;
        _clienteService = clienteService;
    }

    public IActionResult Index()
    {
        var loteList = _loteService.LoteList(); //colocando lista de lotes em loteList
        return View(loteList);
    }

    //inserir Lote no banco
    [HttpPost]
    public IActionResult Create(Lote lote)
    {
        _loteService.Insert(lote);
        return RedirectToAction(nameof(Index));
    }

    //chamar pagina view index de Lote
    
}
