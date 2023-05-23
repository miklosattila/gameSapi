using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.QustionAnswerPickedDto
{
    public class AddQustionAnswerPickedDto
    {

        public bool Corrrect {get;set;}=false;

        public int IncorrectAnswerNumber;

        public int QuestionId {get;init;}

    }
}