using System;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;
using Sphinx.Domain.Repositories.Google.MachineLearning.Vision;

namespace Sphinx.Infrastructure.Repositories.Google.MachineLearning.Vision
{
    public class VisionRepository : IVisionRepository
    {
        public async Task<dynamic> DetectFacesAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectFacesAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectLabelsAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectLabelsAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectSafeSearchAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectSafeSearchAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectCropHintsAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectCropHintsAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectDocumentTextAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectDocumentTextAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectLandmarksAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectLandmarksAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectImagePropertiesAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectImagePropertiesAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectTextAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectTextAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectLogosAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectLogosAsync(Image.FromBytes(image));
        }

        public async Task<dynamic> DetectWebInformationAsync(byte[] image)
        {
            var client = ImageAnnotatorClient.Create();

            return await client.DetectWebInformationAsync(Image.FromBytes(image));
        }
    }
}