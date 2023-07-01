using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.AnswerDto;

namespace Catolog.Dtos.QuestionDto
{
    public class GetQuestionDto
    {

        public string Content {get;set;}="Qustion?";

        //Enum type
        public string Type {get;set;}="Type";

        public int Rank {get;set;}

        public List<GetAnswerDto>? QustionAnswers { get; set; }
     
    }
}