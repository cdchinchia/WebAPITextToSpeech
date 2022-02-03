using Shared.Models;

namespace TextToSpeechTest
{
    public interface IAudioManager
    {
        public string CreateAudioFile(AudioInfo audioInfo);
    }

}


