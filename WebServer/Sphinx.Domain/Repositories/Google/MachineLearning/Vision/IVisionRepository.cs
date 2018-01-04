using System.Threading.Tasks;

namespace Sphinx.Domain.Repositories.Google.MachineLearning.Vision
{
    public interface IVisionRepository
    {
        Task<dynamic> DetectFacesAsync(byte[] image);
        Task<dynamic> DetectLabelsAsync(byte[] image);
        Task<dynamic> DetectDocumentTextAsync(byte[] image);
        Task<dynamic> DetectCropHintsAsync(byte[] image);
        Task<dynamic> DetectSafeSearchAsync(byte[] image);
        Task<dynamic> DetectLandmarksAsync(byte[] image);
        Task<dynamic> DetectImagePropertiesAsync(byte[] image);
        Task<dynamic> DetectTextAsync(byte[] image);
        Task<dynamic> DetectLogosAsync(byte[] image);
        Task<dynamic> DetectWebInformationAsync(byte[] image);
    }
}