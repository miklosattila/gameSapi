using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.PlayerDto;

namespace Catolog
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Player,GetPlayerDto>();
            CreateMap<Player,UpdatePlayerScoreDto>();
        }
    }
}