using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.QustionAnswerPickedDto
{
    public class GetQustionAnswerPickedDto
    {
          public int  Id {get;init;}

        public bool Corrrect {get;set;}=false;

        public int IncorrectAnswerNumber;

        public int QuestionId {get;init;}

        public Question Question { get; set; }=null!;
    }
}