using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Dtos.MapEntityTypeDto;

namespace Catolog.Dtos.MapEntitieDto
{
    public class GetMapEntitieDto
    {



        public int  MapEntityTypeid {get;set;}
        public GetMapEntityTypeDto MapEntityType {get;set;}
    
        public int Xcoordinate {get;set;}

        public int Ycoordinate {get;set;}

  
    }
}