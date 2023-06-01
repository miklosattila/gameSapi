using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.QustionAnswerPickedDto;
using Microsoft.AspNetCore.Mvc;

namespace Catolog.Services.AnswerPickServices
{
    public interface IAnswerPickServices
    {
        Task<ServiceResponse<GetQustionAnswerPickedDto>> PickAnswer(AddQustionAnswerPickedDto addQustionAnswerPickedDto);
        Task<ServiceResponse<GetQustionAnswerPickedDto>> GetAnswerPicked(int id);
    }
}