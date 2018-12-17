using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka.AtributesClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyAttribute : Attribute
    {
        public string referencedTable;
        public string referencedColumn;
        public string className;

        public ForeignKeyAttribute(string table, string column, string name)
        {
            referencedTable = table;
            referencedColumn = column;
            className = name;
        }
    }
}
