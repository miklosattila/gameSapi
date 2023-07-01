using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.MapDto;
using Catolog.Dtos.MapEntitieDto;
using Catolog.Dtos.MapEntityTypeDto;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.MapServices
{
    public class MapServices : IMapServices
    {
        private readonly IMapper _mapper;

        public DataContext _context;

        public MapServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }
        public async Task<ServiceResponse<List<GetMapEntitieDto>>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetMapEntitieDto>>();
            try
            {
                var map = await _context.Maps
                    .Include(c => c.MapEntities)
                        .ThenInclude(q => q.MapEntityType)
                    .FirstOrDefaultAsync(m => m.Id == id);
                
                if (map is null)
                    throw new Exception($"Quiz with Id '{id}' not found.");

                var MapEntityDtos = map.MapEntities.Select(q =>
                {
                    var MapEntitieDto = _mapper.Map<GetMapEntitieDto>(q);
                    MapEntitieDto.MapEntityType = _mapper.Map<GetMapEntityTypeDto>(q.MapEntityType);;
                    return MapEntitieDto;
                }).ToList();
                serviceResponse.Data = MapEntityDtos;
            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetMapQuizDto>>> GetAllQuiz(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetMapQuizDto>>();
            try
            {
                var maps = await _context.Maps
                    .Where(m => m.Id == id)
                    .Include(c => c.Quiz)
                    .ToListAsync();
                if(maps is null)
                    throw new Exception($"Player with Id '{id}' not found.");

                serviceResponse.Data = maps.Select(m => _mapper.Map<GetMapQuizDto>(m)).ToList();

            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }
    }
}