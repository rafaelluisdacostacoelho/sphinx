using System.Threading.Tasks;

namespace Sphinx.Application.Interfaces.Google.MachineLearning.NaturalLanguage
{
    public interface INaturalLanguageService
    {
        Task<dynamic> AnalyzeEntitiesAsync(string text);

        Task<dynamic> AnalyzeSentimentAsync(string text);

        Task<dynamic> AnalyzeSyntaxAsync(string text);

        Task<dynamic> AnalyzeEverythingAsync(string text);
    }
}