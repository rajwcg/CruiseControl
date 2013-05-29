using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
  public  class SpiceCinema:Cinema
    {
        public override List<Movies> GetMovie()
        {
            return new List<Movies>() { new Movies() { Id = 1, CinemaName = "Spice", Name = "Sholay" }, new Movies() { Id = 2, CinemaName = "Spice", Name = "3 Idiots" },new Movies(){ Id = 3, CinemaName = "Spice", Name = "Ghatak"} };
        }
    }
}
