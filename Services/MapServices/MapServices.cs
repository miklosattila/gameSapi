using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.MapDto;
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
        public async Task<ServiceResponse<List<GetMapWithAllResourcesDto>>> GetAllByPlayer(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetMapWithAllResourcesDto>>();
            try
            {
                var maps = await _context.Maps
                    .Where(m => m.PlayerId == id)
                    .Include(c => c.MapEntities)
                    .ToListAsync();
                if(maps is null)
                    throw new Exception($"Player with Id '{id}' not found.");

                serviceResponse.Data = maps.Select(m => _mapper.Map<GetMapWithAllResourcesDto>(m)).ToList();

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