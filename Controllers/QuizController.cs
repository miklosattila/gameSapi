using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuestionDto;
using Catolog.Dtos.QuizDto;
using Catolog.Services.QuizServices;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Controllers 
{
    [ApiController]
    [Route("quiz/")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizServices _quizrServices;

        public QuizController(IQuizServices quizrServices)
        {
            _quizrServices= quizrServices;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetQuizDto>>>> GetAllPlayers()
        {
            
            return Ok(await _quizrServices.GetAllQuiz());
        }

        [HttpGet("GetQuizQuestion/{id}")]
public async Task<ActionResult<ServiceResponse<List<GetQuestionDto>>>> GetQuizQuestions(int id)
{
    var response = await _quizrServices.GetQuizQuestions(id);

    if (!response.Success)
    {
        return BadRequest(response);
    }

    return Ok(response.Data);
}
    }

     
}