using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.QuizAnswerDto
{
    public class GetQuizAnswerDto
    {
        public string Name {get;set;}="Quiz Answer";

        public string? Title {get;set;}

        public int CurentLife {get;set;}
        
        public int Score {get; set;}

        public List<Question>? AllQustionAnswers { get; set; }
    }
}