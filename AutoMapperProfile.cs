using AutoMapper;
using Catolog.Dtos.AnswerDto;
using Catolog.Dtos.MapDto;
using Catolog.Dtos.MapEntitieDto;
using Catolog.Dtos.MapEntityTypeDto;
using Catolog.Dtos.QuestionDto;
using Catolog.Dtos.QuizDto;
using Catolog.Dtos.QustionAnswerPickedDto;
using Catolog.Models;

namespace Catolog
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Player, GetPlayerDto>();
            CreateMap<Player, UpdatePlayerScoreDto>();
            CreateMap<MapEntity, MapEntityDto>();
            CreateMap<Map, GetMapWithAllResourcesDto>();
            CreateMap<Map, GetMapQuizDto>();
            CreateMap<Quiz, GetQuizDto>();
            CreateMap<QustionAnswerPicked, AddQustionAnswerPickedDto>();
            CreateMap<QustionAnswerPicked, GetQustionAnswerPickedDto>();
            CreateMap<Question, GetQuestionDto>();
            CreateMap<QustionAnswer, GetAnswerDto>();
            CreateMap<MapEntity, GetMapEntitieDto>();
            CreateMap<MapEntityType, GetMapEntityTypeDto>();

        }
    }
}
