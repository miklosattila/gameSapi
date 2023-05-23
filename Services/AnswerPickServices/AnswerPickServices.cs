using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.QustionAnswerPickedDto;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.AnswerPickServices
{
    public class AnswerPickServices : IAnswerPickServices
    {
        private readonly IMapper _mapper;

        public DataContext _context;
       
        public AnswerPickServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }
        public async Task<ServiceResponse<List<AddQustionAnswerPickedDto>>> AddAnswer(AddQustionAnswerPickedDto addQustionAnswerPickedDto)
        {
            var serviceResponse = new ServiceResponse<List<AddQustionAnswerPickedDto>>();
            var answer = _mapper.Map<QustionAnswerPicked>(addQustionAnswerPickedDto);
            _context.QustionAnswersPicked.Add(answer);
            await _context.SaveChangesAsync();

             serviceResponse.Data =
                await _context.QustionAnswersPicked
                    .Select(c => _mapper.Map<AddQustionAnswerPickedDto>(c))
                    .ToListAsync();
            return serviceResponse;
        }
    }
}