using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concrete;

namespace Factories
{
   public  class FactoryInvoice
    {

       static public IInvoice GetInvoice(int intInvoiceType)
       {
           IInvoice objinv;
           switch (intInvoiceType)
           {
               case 1:
                   objinv = new ClsInvoiceWithHeader();
                   break;
               case 2:
                   objinv = new ClsInvoiceWithOutHeaders();
                   break;
               default:
                   return null;
           }
           return objinv;
       }
    }
}
