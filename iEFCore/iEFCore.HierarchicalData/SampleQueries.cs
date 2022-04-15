using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.HierarchicalData;

public class SampleQueries
{
    private readonly HierarchicalDbContext hierarchicalDbContext;

    public SampleQueries (HierarchicalDbContext hierarchicalDbContext)
        {
        this.hierarchicalDbContext = hierarchicalDbContext;
    }
    public void AddTypes(int start , int count)
    {
        for (int i = start; i < count; i++)
        {
            var type01 = new Type01
            {
                Name = $"Type01Name{i}",
            };
            type01.Type02s = new List<Type02>();
            for (int j = start; j < count; j++)
            {
                var type02 = new Type02
                {
                    Name = $"Type02Name{j}",
                };
                type02.Type03s = new List<Type03>();
                for (int k = start; k < count; k++)
                {
                    var type03 = new Type03
                    {
                        Name = $"Type03Name{k}",
                    };
                    type02.Type03s.Add(type03);
                }
                type01.Type02s.Add(type02);
            }
            hierarchicalDbContext.Type01s.Add(type01);
        }
        hierarchicalDbContext.SaveChanges();

    }
}
