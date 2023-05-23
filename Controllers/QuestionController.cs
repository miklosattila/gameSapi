using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuestionDto;
using Catolog.Dtos.QustionAnswerPickedDto;
using Catolog.Services.QuestionServices;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Controllers
{   
    [ApiController]
    [Route("Question/")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionServices _questionServices;

        public QuestionController(IQuestionServices quizrServices)
        {
            _questionServices= quizrServices;
        }

        [HttpGet("GetQuestion/{id}")]
        public async Task<ActionResult<ServiceResponse<GetQuestionDto>>> GetQuestion(int id)
        {
            return Ok(await _questionServices.GetQuestion(id));
        }

        



    }
}