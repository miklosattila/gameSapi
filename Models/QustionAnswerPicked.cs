using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Models
{
    public class QustionAnswerPicked
    {
        public int  Id {get;init;}

        public bool Corrrect {get;set;}=false;

        public int IncorrectAnswerNumber;

        public int QuestionId {get;init;}

        public Question Question { get; set; }=null!;
        
        public DateTimeOffset CreatedDate {get; init; }

        public string? CreatedAT {get; init; }
    }
}