using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB
{
   public class DataAccess
   {
       private readonly DesignPatternEntities _designPatternEntities;
       public DataAccess()
       {
           _designPatternEntities = new DesignPatternEntities();
       }

       public List<PatternList> GetPatternList()
       {

           return _designPatternEntities.PatternLists.ToList();
       }
    }
}
