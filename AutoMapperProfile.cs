using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.MapDto;
using Catolog.Dtos.PlayerDto;
using Catolog.Dtos.QuestionDto;
using Catolog.Dtos.QuizDto;
using Catolog.Dtos.QustionAnswerPickedDto;

namespace Catolog
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Player,GetPlayerDto>();
            CreateMap<Player,UpdatePlayerScoreDto>();
            CreateMap<MapEntity, MapEntityDto>();
            CreateMap<Map, GetMapWithAllResourcesDto>();
                // .ForMember(dest => dest.MapEntities, opt => opt.MapFrom(src => src.MapEntities.Select(me => new MapEntityDto
                // {
                //     Xcoordinate = me.Xcoordinate, // További tulajdonságok
                //     Ycoordinate = me.Ycoordinate,
                //     EntityType = me.EntityType
                // }).ToList()));
            CreateMap<Map, GetMapQuizDto>();
            CreateMap<Quiz, GetQuizDto>();
           CreateMap<QustionAnswerPicked, AddQustionAnswerPickedDto>();
           CreateMap<QustionAnswerPicked, GetQustionAnswerPickedDto>();
           CreateMap<Question, GetQuestionDto>();

        }
    }
}