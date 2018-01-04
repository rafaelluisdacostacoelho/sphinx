using System.Threading.Tasks;

namespace Sphinx.Domain.Repositories.Google.MachineLearning.NaturalLanguage
{
    public interface INaturalLanguageRepository
    {
        Task<dynamic> AnalyzeEntitiesAsync(string text);
        Task<dynamic> AnalyzeSentimentAsync(string text);
        Task<dynamic> AnalyzeSyntaxAsync(string text);
        Task<dynamic> AnalyzeEverythingAsync(string text);
    }
}