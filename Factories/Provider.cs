using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concrete;
namespace Factories
{
   public class Provider
   {
       private Cinema _cinema;
       public Cinema GetCinema(MovieProvider provider)
      {
         
           switch (provider)
           {
               case MovieProvider.WaveCinema:
                   _cinema = new WaveCinema();
                   break;
               case MovieProvider.SpiceCinema:
                   _cinema = new SpiceCinema();
                   break;
               case MovieProvider.PVRCinema:
                 throw new ArgumentOutOfRangeException("provider");
               default:
                   throw new ArgumentOutOfRangeException("provider");
           }


           return _cinema;
      }
    }
}
