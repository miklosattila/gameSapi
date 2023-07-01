using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.MapDto;
using Catolog.Dtos.MapEntitieDto;

namespace Catolog.Services.MapServices
{
    public interface IMapServices
    {
        Task<ServiceResponse<List<GetMapEntitieDto>>> GetById(int id);

        Task<ServiceResponse<List<GetMapQuizDto>>> GetAllQuiz(int id);
    }
}