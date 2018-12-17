using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka.AtributesClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SqlNameAttribute : Attribute
    {
        public string Name;
        public SqlNameAttribute(string name)
        {
            this.Name = name;
        }
        
    }
}
