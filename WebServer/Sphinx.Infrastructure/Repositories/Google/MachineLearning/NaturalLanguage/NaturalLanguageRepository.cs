using Google.Cloud.Language.V1;
using Sphinx.Domain.Repositories.Google.MachineLearning.NaturalLanguage;
using System.Threading.Tasks;

using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Sphinx.Infrastructure.Repositories.Google.MachineLearning.NaturalLanguage
{
    public class NaturalLanguageRepository : INaturalLanguageRepository
    {
        public async Task<dynamic> AnalyzeEntitiesAsync(string text)
        {
            var client = await LanguageServiceClient.CreateAsync();

            return await client.AnalyzeEntitiesAsync(new Document
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
        }

        public async Task<dynamic> AnalyzeSentimentAsync(string text)
        {
            var client = await LanguageServiceClient.CreateAsync();

            return await client.AnalyzeSentimentAsync(new Document
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
        }

        public async Task<dynamic> AnalyzeSyntaxAsync(string text)
        {
            var client = await LanguageServiceClient.CreateAsync();

            return await client.AnalyzeSyntaxAsync(new Document
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
        }

        public async Task<dynamic> AnalyzeEverythingAsync(string text)
        {
            var client = await LanguageServiceClient.CreateAsync();

            return await client.AnnotateTextAsync(new Document
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            }, new Features
            {
                ExtractSyntax = true,
                ExtractDocumentSentiment = true,
                ExtractEntities = true
            });
        }
    }
}