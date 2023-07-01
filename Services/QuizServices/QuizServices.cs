using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.AnswerDto;
using Catolog.Dtos.QuestionDto;
using Catolog.Dtos.QuizDto;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Catolog.Services.QuizServices
{
    public class QuizServices : IQuizServices
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public QuizServices(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetQuizDto>>> GetAllQuiz()
        {
            var serviceResponse = new ServiceResponse<List<GetQuizDto>>();
            try
            {
                var quizzes = await _context.Quizzes.ToListAsync();
                if (quizzes is null)
                    throw new Exception($"Not found.");

                serviceResponse.Data = quizzes.Select(m => _mapper.Map<GetQuizDto>(m)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetQuestionDto>>> GetQuizQuestions(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetQuestionDto>>();
            try
            {
                var quiz = await _context.Quizzes
                    .Include(q => q.Questions)
                        .ThenInclude(q => q.QustionAnswers)
                    .FirstOrDefaultAsync(m => m.Id == id);

                if (quiz is null)
                    throw new Exception($"Quiz with Id '{id}' not found.");

                var questionDtos = quiz.Questions.Select(q =>
                {
                    var questionDto = _mapper.Map<GetQuestionDto>(q);
                    questionDto.QustionAnswers = q.QustionAnswers.Select(a => _mapper.Map<GetAnswerDto>(a)).ToList();
                    return questionDto;
                }).ToList();

                serviceResponse.Data = questionDtos;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
