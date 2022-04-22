using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.OneToMany.OneToManySample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int ProductId { get; set; }
    }
}
