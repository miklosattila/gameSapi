using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Catolog.Dtos.QustionAnswerPickedDto;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ServiceResponse<GetQustionAnswerPickedDto>> GetAnswerPicked(int id)
        {
            var serviceResponse = new ServiceResponse<GetQustionAnswerPickedDto>();
            var answer = await _context.QustionAnswersPicked.FirstOrDefaultAsync(c => c.Id == id);
            if(answer is not null){
                serviceResponse.Data = _mapper.Map<GetQustionAnswerPickedDto>(answer);
                return serviceResponse;
                }
            serviceResponse.Success=false;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetQustionAnswerPickedDto>> PickAnswer(AddQustionAnswerPickedDto request)
        {
            var newQustionAnswerPicked = new QustionAnswerPicked
            {
                Corrrect=request.Corrrect,

                IncorrectAnswerNumber=request.IncorrectAnswerNumber,

                QuestionId=request.QuestionId
            };

            await _context.QustionAnswersPicked.AddAsync(newQustionAnswerPicked);
            await _context.SaveChangesAsync();

            return await GetAnswerPicked(newQustionAnswerPicked.Id);
        }
    }
}