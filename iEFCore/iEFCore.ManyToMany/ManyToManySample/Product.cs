using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.ManyToMany.ManyToManySample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

    public class PTRelationEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }

}
