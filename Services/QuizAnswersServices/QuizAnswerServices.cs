using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.QuizAnswerDto;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.QuizAnswersServices
{
    public class QuizAnswerServices : IQuizAnswerServices
    {
        private readonly IMapper _mapper;

        public DataContext _context;
        public QuizAnswerServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }
        public async Task<ServiceResponse<GetQuizAnswerDto>> GetQuizAnswers(int id)
        {
            var serviceResponse = new ServiceResponse<GetQuizAnswerDto>();
            try
            {
                var quizAnswer = await _context.QuizAnswers
                    .FirstOrDefaultAsync(m => m.Id == id);
                if(quizAnswer is null)
                    throw new Exception($"Quiz with Id '{id}' not found.");

                serviceResponse.Data = _mapper.Map<GetQuizAnswerDto>(quizAnswer);

            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetQuizAnswerDto>> PickQuizAnswer(AddQuizAnswerDto request)
        {
            List<Question> answerQuestions = new List<Question>();

            foreach(int id  in request.QuestionIdList)
            {
                var question = await _context.Questions
                    .FirstOrDefaultAsync(m => m.Id == id && m.QuizId == request.QuizId);
                answerQuestions.Add(question);
            }

            var newQuizAnswer = new QuizAnswer
            {
                Name=request.Name,

                Title=request.Title,

                CurentLife=request.CurentLife,

                AllQustionAnswers=answerQuestions

            };
            await _context.QuizAnswers.AddAsync(newQuizAnswer);
            await _context.SaveChangesAsync();

            return await GetQuizAnswers(newQuizAnswer.Id);
        }
    }
}