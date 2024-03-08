using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instacias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Sabina silva roberto", "123.456.789-12", " Sabinarsr@gamil.com", " mel");
        Cliente cliente2 = new Cliente(02, "Tania arruda matos", "123.456.789-13", " Taniaaam@gamil.com","sol" );
        Cliente cliente3 = new Cliente(03, "Marcelle escura pinto", "123.456.789-14", " Marcelleea@gamil.com","lua");
        Cliente cliente4 = new Cliente(04, "Julio cesar freitas", "123.456.789-15", " Juliocf@gamil.com","pao");
        Cliente cliente5 = new Cliente(05, "Bernado freitas cesar ", "123.456.789-16", " Bernardofc@gamil.com", "noa");

        //Lista de clientes e atributos
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        ViewBag.listaClientes = listaClientes;
        // Instacia do tipo fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "C#PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "CtrlAlt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "40.810.224/0001-83","boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever", "18.760.614/0001-37","contato@bff.us");

        //lista de fornecedores e atributos
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        ViewBag.listaFornecedores = listaFornecedores;
        return View();
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
