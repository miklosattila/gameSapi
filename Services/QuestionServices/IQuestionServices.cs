using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QuestionDto;

namespace Catolog.Services.QuestionServices
{
    public interface IQuestionServices
    {
        Task<ServiceResponse<GetQuestionDto>> GetQuestion(int id);
    }
}