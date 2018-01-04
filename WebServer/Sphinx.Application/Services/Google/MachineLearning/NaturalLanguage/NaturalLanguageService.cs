using Sphinx.Application.Interfaces.Google.MachineLearning.NaturalLanguage;
using Sphinx.Domain.Repositories.Google.MachineLearning.NaturalLanguage;
using System.Threading.Tasks;

namespace Sphinx.Application.Services.Google.MachineLearning.NaturalLanguage
{
    public class NaturalLanguageService : INaturalLanguageService
    {
        private readonly INaturalLanguageRepository repository;
        public NaturalLanguageService(INaturalLanguageRepository repository)
        {
            this.repository = repository;
        }

        public async Task<dynamic> AnalyzeEntitiesAsync(string text)
        {
            return await repository.AnalyzeEntitiesAsync(text);
        }

        public async Task<dynamic> AnalyzeSentimentAsync(string text)
        {
            return await repository.AnalyzeSentimentAsync(text);
        }

        public async Task<dynamic> AnalyzeSyntaxAsync(string text)
        {
            return await repository.AnalyzeSyntaxAsync(text);
        }

        public async Task<dynamic> AnalyzeEverythingAsync(string text)
        {
            return await repository.AnalyzeEverythingAsync(text);
        }
    }
}