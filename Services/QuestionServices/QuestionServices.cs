using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.QuestionDto;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.QuestionServices
{
    public class QuestionServices : IQuestionServices
    {
        private readonly IMapper _mapper;

        public DataContext _context;
        public QuestionServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }
        public async Task<ServiceResponse<GetQuestionDto>> GetQuestion(int id)
        {
             var serviceResponse = new ServiceResponse<GetQuestionDto>();
            try
            {
                var question = await _context.Questions
                    .FirstOrDefaultAsync(m => m.Id == id);
                if(question is null)
                    throw new Exception($"Quiz with Id '{id}' not found.");

                serviceResponse.Data = _mapper.Map<GetQuestionDto>(question);

            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }
    }
}