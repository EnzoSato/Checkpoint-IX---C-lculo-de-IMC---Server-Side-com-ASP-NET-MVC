using Microsoft.AspNetCore.Mvc;
using CalculadoraImc.Models;

namespace CalculadoraImc.Controllers
{
    public class ImcController : Controller
    {
        // GET: Apenas mostra o formulário vazio
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ImcModel());
        }

        // POST: Recebe os dados e faz o cálculo no SERVIDOR (Server Side)
        [HttpPost]
        public IActionResult Index(ImcModel model)
        {
            if (model.Peso > 0 && model.Altura > 0)
            {
                // Cálculo do IMC
                model.ResultadoImc = model.Peso / (model.Altura * model.Altura);

                // Define a classificação
                if (model.ResultadoImc < 18.5) model.Classificacao = "Abaixo do peso";
                else if (model.ResultadoImc < 24.9) model.Classificacao = "Peso normal";
                else if (model.ResultadoImc < 29.9) model.Classificacao = "Sobrepeso";
                else model.Classificacao = "Obesidade";
            }

            // Devolve a mesma tela, mas agora com os resultados calculados
            return View(model);
        }
    }
}