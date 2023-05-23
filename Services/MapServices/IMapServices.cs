using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.MapDto;

namespace Catolog.Services.MapServices
{
    public interface IMapServices
    {
        Task<ServiceResponse<List<GetMapWithAllResourcesDto>>> GetAllByPlayer(int id);

        Task<ServiceResponse<List<GetMapQuizDto>>> GetAllQuiz(int id);
    }
}