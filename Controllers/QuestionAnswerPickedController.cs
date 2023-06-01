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
        public async Task<ActionResult> PickAnswer(AddQustionAnswerPickedDto request){

            if( request is null){
                return NotFound(request);
            }
            var response = await _quizrServices.PickAnswer(request);
            return Ok(response);

        }
    }
}