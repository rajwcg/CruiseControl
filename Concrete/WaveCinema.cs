using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
   public class WaveCinema:Cinema
    {
        public override List<Movies> GetMovie()
        {
            return new List<Movies>() { new Movies() { Id = 1, CinemaName = "Wave", Name = "Ek thi dian" }, new Movies() { Id = 2, CinemaName = "Wave", Name = "Matrix" }, new Movies() { Id = 3, CinemaName = "Wave", Name = "DDLJ" } };
        }
    }
}
