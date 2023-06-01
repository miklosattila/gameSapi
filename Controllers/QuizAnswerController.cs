using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuizAnswerDto;
using Catolog.Services.QuizAnswersServices;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Controllers
{
    [ApiController]
    [Route("quizanswer/")]
    public class QuizAnswerController : ControllerBase
    {
        private readonly IQuizAnswerServices _quizAnswerServices;

        public QuizAnswerController(IQuizAnswerServices quizAnswerServices)
        {
            _quizAnswerServices= quizAnswerServices;
        }

        [HttpGet("GetQuizQuestion/{id}")]
        public async Task<ActionResult<ServiceResponse<GetQuizAnswerDto>>> GetQuizQuestions(int id)
        {
            return Ok(await _quizAnswerServices.GetQuizAnswers(id));
        }
        [HttpPut("PickAnswer")]
        public async Task<ActionResult> PickAnswer(AddQuizAnswerDto request){

            if( request is null){
                return NotFound(request);
            }
            var response = await _quizAnswerServices.PickQuizAnswer(request);
            return Ok(response);

        }
    }
}