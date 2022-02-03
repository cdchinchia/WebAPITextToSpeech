using System.IO;
using Google.Cloud.TextToSpeech.V1;
using Grpc.Core;
using Shared.Models;


namespace TextToSpeechTest
{

    public class AudioManager : IAudioManager
    {
        private readonly TextToSpeechClient _client;
        public AudioManager() 
        {
            _client = TextToSpeechClient.Create();
        }

        public string CreateAudioFile(AudioInfo audioInfo)
        {
            SynthesisInput synthesisInput = new()
            {
                Text = audioInfo.Text
            };
            VoiceSelectionParams voiceSelection = new()
            {
                LanguageCode = audioInfo.Language,
               
                SsmlGender = SsmlVoiceGender.Male
            };
            AudioConfig audioConfig = new()
            {
                AudioEncoding = AudioEncoding.Linear16,
                //Pitch = 0,
                //SpeakingRate = (double)audioInfo.SpeakingRate,
                SampleRateHertz = 8000
            };

            var response = _client.SynthesizeSpeech(synthesisInput, voiceSelection, audioConfig);


            string path = @"D:\CRISTIAN-PERSONAL\ASP.NET Core 3.1 y5\Proyectos\TextToSpeechAPI\WebAPITextToSpeech\WebAPITextToSpeech\wwwroot\AudioDirectory\output.wav";
            //string path = @"C:\credencialesGoogle\output.wav";
            //string path = "{content root}/wwwroot/AudioDirectory/output.wav";

            using (FileStream output = File.Create(path))
            {
                response.AudioContent.WriteTo(output);
            }
            return path;
        }

    }

}


