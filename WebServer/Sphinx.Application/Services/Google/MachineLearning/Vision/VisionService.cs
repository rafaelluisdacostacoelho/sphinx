using Sphinx.Application.Interfaces.Google.MachineLearning.Vision;
using System.Threading.Tasks;
using Sphinx.Domain.Repositories.Google.MachineLearning.Vision;

namespace Sphinx.Application.Services.Google.MachineLearning.Vision
{
    public class VisionService : IVisionService
    {
        private readonly IVisionRepository repository;
        public VisionService(IVisionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<dynamic> DetectFacesAsync(byte[] image)
        {
            var faces = await repository.DetectFacesAsync(image);

            return faces;
        }

        public async Task<dynamic> DetectLabelsAsync(byte[] image)
        {
            var labels = await repository.DetectLabelsAsync(image);

            return labels;
        }

        public async Task<dynamic> DetectDocumentTextAsync(byte[] image)
        {
            var documentText = await repository.DetectDocumentTextAsync(image);

            return documentText;
        }

        public async Task<dynamic> DetectCropHintsAsync(byte[] image)
        {
            var cropHints = await repository.DetectCropHintsAsync(image);

            return cropHints;
        }

        public async Task<dynamic> DetectSafeSearchAsync(byte[] image)
        {
            var safeSearch = await repository.DetectSafeSearchAsync(image);

            return safeSearch;
        }

        public async Task<dynamic> DetectLandmarksAsync(byte[] image)
        {
            var landmarks = await repository.DetectLandmarksAsync(image);

            return landmarks;
        }

        public async Task<dynamic> DetectImagePropertiesAsync(byte[] image)
        {
            var imageProperties = await repository.DetectImagePropertiesAsync(image);

            return imageProperties;
        }

        public async Task<dynamic> DetectTextAsync(byte[] image)
        {
            var text = await repository.DetectTextAsync(image);

            return text;
        }

        public async Task<dynamic> DetectLogosAsync(byte[] image)
        {
            var logos = await repository.DetectLogosAsync(image);

            return logos;
        }

        public async Task<dynamic> DetectWebInformationAsync(byte[] image)
        {
            var webInformation = await repository.DetectWebInformationAsync(image);

            return webInformation;
        }
    }
}
