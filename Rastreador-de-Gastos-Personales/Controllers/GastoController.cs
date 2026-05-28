using Microsoft.AspNetCore.Mvc;
using Rastreador_de_Gastos_Personales.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rastreador_de_Gastos_Personales.Controllers
{
    public class GastoController : Controller
    {
        public IActionResult Index()
        {
            // 1. Creamos los datos simulados aquí en el cerebro
            var listaGastos = new List<Gasto>
            {
                new Gasto { Id = 1, Descripcion = "Pasaje Caribe Tours", Monto = 12.00m, Categoria = "Transporte" },
                new Gasto { Id = 2, Descripcion = "Cena rápida", Monto = 55.50m, Categoria = "Comida" },
                new Gasto { Id = 3, Descripcion = "Artículos de tecnología", Monto = 20.00m, Categoria = "Entretenimiento" }
            };

            // Calculamos el total y lo pasamos usando ViewBag (una caja de herramientas de .NET)
            ViewBag.TotalGastado = listaGastos.Sum(g => g.Monto);
            ViewBag.NombreUsuario = "Desarrollador";

            // 2. Le inyectamos la lista directamente a la vista dentro de los paréntesis
            return View(listaGastos);
        }
    }
}