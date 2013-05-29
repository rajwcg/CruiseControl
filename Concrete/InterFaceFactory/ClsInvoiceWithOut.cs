using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable CheckNamespace
namespace Concrete
// ReSharper restore CheckNamespace
{
   public class ClsInvoiceWithOutHeaders:IInvoice
    {
       public string Print()
       {
           return "Invoice will be printed without headers";
       }
    }
}
