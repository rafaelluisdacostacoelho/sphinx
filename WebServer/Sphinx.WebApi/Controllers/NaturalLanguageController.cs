using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sphinx.Application.Interfaces.Google.MachineLearning.NaturalLanguage;

namespace Sphinx.WebApi.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/v1/natural-language")]
    public class NaturalLanguageController : Controller
    {
        private readonly INaturalLanguageService service;

        public NaturalLanguageController(INaturalLanguageService service)
        {
            this.service = service;
        }

        [Route("analyze-entities")]
        [HttpGet]
        public async Task<IActionResult> AnalyzeEntitiesAsync(string text)
        {
            return Ok(await service.AnalyzeEntitiesAsync(text));
        }

        [Route("analyze-sentiment")]
        [HttpGet]
        public async Task<IActionResult> AnalyzeSentimentAsync(string text)
        {
            return Ok(await service.AnalyzeSentimentAsync(text));
        }

        [Route("analyze-syntax/{text}")]
        [HttpGet]
        public async Task<IActionResult> AnalyzeSyntaxAsync(string text)
        {
            return Ok(await service.AnalyzeSyntaxAsync(text));
        }

        [Route("analyze-everything")]
        [HttpGet]
        public async Task<IActionResult> AnalyzeEverythingAsync(string text)
        {
            return Ok(await service.AnalyzeEverythingAsync(text));
        }
    }
}