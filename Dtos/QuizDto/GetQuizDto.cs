using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.QuizDto
{
    public class GetQuizDto
    {
        public string Name { get; set; }
        public string? Title { get; set; }
        public int CurrentLife { get; set; }
        public int Score { get; set; }
        public List<Question>? Questions { get; set; }
    }
}