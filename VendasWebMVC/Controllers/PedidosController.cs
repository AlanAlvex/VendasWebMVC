using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Services;

namespace VendasWebMVC.Controllers
{
    public class PedidosController : Controller
    {
        private readonly PedidoService _pedidoService;

        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!minDate.HasValue)
            {
                minDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = minDate.Value.ToString("yyyy-MM-dd");

            var result = await _pedidoService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public IActionResult BuscaGrupo()
        {
            return View();
        }
    }
}
