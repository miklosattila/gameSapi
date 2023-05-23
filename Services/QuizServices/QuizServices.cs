using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.QuizDto;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.QuizServices
{
    public  class QuizServices : IQuizServices
    {
        private readonly IMapper _mapper;

        public DataContext _context;
        public QuizServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }
        public async Task<ServiceResponse<List<GetQuizDto>>> GetAllQuiz()
        {
             var serviceResponse = new ServiceResponse<List<GetQuizDto>>();
             try
            {
                var quizzes = await _context.Quizzes.ToListAsync();
                if(quizzes is null)
                    throw new Exception($"Not found.");

                serviceResponse.Data = quizzes.Select(m => _mapper.Map<GetQuizDto>(m)).ToList();

            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }
        public async Task<ServiceResponse<GetQuizDto>> GetQuizQuestions(int id)
        {
            var serviceResponse = new ServiceResponse<GetQuizDto>();
            try
            {
                var quiz = await _context.Quizzes
                    .FirstOrDefaultAsync(m => m.Id == id);
                if(quiz is null)
                    throw new Exception($"Quiz with Id '{id}' not found.");

                serviceResponse.Data = _mapper.Map<GetQuizDto>(quiz);

            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }


    }
}