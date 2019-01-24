using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka.AttributesClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckValue :  Attribute
    {
    }
}
