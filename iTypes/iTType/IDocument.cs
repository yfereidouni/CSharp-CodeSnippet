using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.TType
{
    public interface IDocument
    {
        string Name { get; set; }

        string GetString();
    }
}
