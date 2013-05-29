using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable CheckNamespace
namespace Concrete
// ReSharper restore CheckNamespace
{
    public class ClsInvoiceWithHeader : IInvoice
    {
        public string Print()
        {
            return  "Invoice will be printed with  headers";
        }
    }
}
