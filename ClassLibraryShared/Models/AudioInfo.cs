
using Google.Cloud.TextToSpeech.V1;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class AudioInfo
    {
        [Required]
        public string Text { get; set; }
        //[MaxLength(5000, ErrorMessage = "The input size is limited to 5000 characters.")]
        public string Language { get; set; }
        //[MaxLength(6, ErrorMessage = "Pleae enter a valid ")]
        //public string Name { get; set; }
        
        //public enum SsmlVoiceGender {  }
        //public SsmlVoiceGender Gender { get; set; }
        //public enum AudioEncoding { }
        //public AudioEncoding audioEncoding { get; set; }
        
        //public int SamplerateHertz { get; set; }

        //public int SpeakingRate { get; set; }
       // public SsmlVoiceGender Male { get; set; }
    }
}
