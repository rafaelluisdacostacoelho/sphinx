using Microsoft.Extensions.DependencyInjection;
using Sphinx.Application.Interfaces.Google.MachineLearning.NaturalLanguage;
using Sphinx.Application.Interfaces.Google.MachineLearning.Vision;
using Sphinx.Application.Services.Google.MachineLearning.NaturalLanguage;
using Sphinx.Application.Services.Google.MachineLearning.SpeechRecognition;
using Sphinx.Application.Services.Google.MachineLearning.VideoIntelligence;
using Sphinx.Application.Services.Google.MachineLearning.Vision;
using Sphinx.Domain.Repositories.Google.MachineLearning.NaturalLanguage;
using Sphinx.Domain.Repositories.Google.MachineLearning.SpeechRecognition;
using Sphinx.Domain.Repositories.Google.MachineLearning.VideoIntelligence;
using Sphinx.Domain.Repositories.Google.MachineLearning.Vision;
using Sphinx.Infrastructure.Repositories.Google.MachineLearning.NaturalLanguage;
using Sphinx.Infrastructure.Repositories.Google.MachineLearning.SpeechRecognition;
using Sphinx.Infrastructure.Repositories.Google.MachineLearning.VideoIntelligence;
using Sphinx.Infrastructure.Repositories.Google.MachineLearning.Vision;

namespace Sphinx.CrossCutting
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<INaturalLanguageService, NaturalLanguageService>();
            //services.AddScoped<ISpeechRecognitionService, SpeechRecognitionService>();
            //services.AddScoped<IVideoIntelligenceService, VideoIntelligenceService>();
            services.AddScoped<IVisionService, VisionService>();

            services.AddScoped<INaturalLanguageRepository, NaturalLanguageRepository>();
            //services.AddScoped<ISpeechRecognitionRepository, SpeechRecognitionRepository>();
            //services.AddScoped<IVideoIntelligenceRepository, VideoIntelligenceRepository>();
            services.AddScoped<IVisionRepository, VisionRepository>();
        }
    }
}