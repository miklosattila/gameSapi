using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QustionAnswerPickedDto;
using Catolog.Services.AnswerPickServices;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Controllers
{
    [ApiController]
    [Route("quizpicker/")]
    public class QuestionAnswerPickedController : ControllerBase
    {
        
        private readonly IAnswerPickServices _quizrServices;

        public QuestionAnswerPickedController(IAnswerPickServices quizrServices)
        {
            _quizrServices= quizrServices;
        }

        [HttpPut("PickAnswer")]
        public async Task<ActionResult> UpdatePlayerScore(AddQustionAnswerPickedDto addQustionAnswerPickedDto){

            var response = await _quizrServices.AddAnswer(addQustionAnswerPickedDto);
            if( response.Data is null){
                return NotFound(response);
            }
            return Ok(response);

        }
    }
}