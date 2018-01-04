using System.Threading.Tasks;

namespace Sphinx.Domain.Repositories.Google.MachineLearning.SpeechRecognition
{
    public interface ISpeechRecognitionRepository
    {
         Task<dynamic> AnalyzeSpeechAsync(byte[] audio, int frequency, string language, int encoding);
         Task<dynamic> LongRunninReconizeAsync(byte[] audio, int frequency, string language, int encoding);
    }
}