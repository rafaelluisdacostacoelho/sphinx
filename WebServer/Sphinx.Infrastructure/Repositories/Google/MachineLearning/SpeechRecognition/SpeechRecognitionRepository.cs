using Google.Cloud.Speech.V1;
using Sphinx.Domain.Repositories.Google.MachineLearning.SpeechRecognition;
using System.Threading.Tasks;

namespace Sphinx.Infrastructure.Repositories.Google.MachineLearning.SpeechRecognition
{
    public class SpeechRecognitionRepository : ISpeechRecognitionRepository
    {
        public async Task<dynamic> AnalyzeSpeechAsync(byte[] audio, int frequency, string language, int encoding)
        {
            var client = SpeechClient.Create();

            return await client.RecognizeAsync(new RecognitionConfig
            {
                Encoding = (RecognitionConfig.Types.AudioEncoding)encoding,
                SampleRateHertz = frequency,
                LanguageCode = language
            }, RecognitionAudio.FromBytes(audio));
        }

        public async Task<dynamic> LongRunninReconizeAsync(byte[] audio, int frequency, string language, int encoding)
        {
            var client = SpeechClient.Create();

            return await client.LongRunningRecognizeAsync(new RecognitionConfig
            {
                Encoding = (RecognitionConfig.Types.AudioEncoding)encoding,
                SampleRateHertz = frequency,
                LanguageCode = language
            }, RecognitionAudio.FromBytes(audio));
        }
    }
}