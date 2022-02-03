using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextToSpeechTest;

namespace WebAPITextToSpeech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextToSpeechController : ControllerBase
    {
        private readonly IAudioManager _audioManager;



        public TextToSpeechController(IAudioManager audioManager)
        {
            _audioManager = audioManager;
        }

                

        [HttpPost]
        public IActionResult Post(AudioInfo audioInfo)
        {
            string filePath = _audioManager.CreateAudioFile(audioInfo);
            if (filePath is null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(filePath);
        }


    }
}
