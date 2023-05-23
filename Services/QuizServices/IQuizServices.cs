using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuizDto;

namespace Catolog.Services.QuizServices
{
    public interface IQuizServices
    {
       Task<ServiceResponse<List<GetQuizDto>>> GetAllQuiz();
       Task<ServiceResponse<GetQuizDto>> GetQuizQuestions(int id);
    }
}