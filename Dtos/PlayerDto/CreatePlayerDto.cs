using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catolog.Dtos.PlayerDto
{
    public class CreatePlayerDto
    {

        public string Name {get;set;}="Player";

        public int Age {get;set;}=1;

        public DateTimeOffset CreatedDate {get; init; }

        public DateTimeOffset ExitDate {get;set;}

        public int QuizScore {get; set;}=0;

        public int GameScore {get;set;}=0;
    }
}