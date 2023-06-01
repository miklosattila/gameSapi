using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuizAnswerDto;

namespace Catolog.Services.QuizAnswersServices
{
    public interface IQuizAnswerServices
    {
        Task<ServiceResponse<GetQuizAnswerDto>> GetQuizAnswers(int id);
        Task<ServiceResponse<GetQuizAnswerDto>> PickQuizAnswer(AddQuizAnswerDto addQuizAnswerDto);
    }
}