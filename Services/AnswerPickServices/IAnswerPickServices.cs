using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QustionAnswerPickedDto;

namespace Catolog.Services.AnswerPickServices
{
    public interface IAnswerPickServices
    {
        Task<ServiceResponse<List<AddQustionAnswerPickedDto>>> AddAnswer(AddQustionAnswerPickedDto addQustionAnswerPickedDto);
    }
}