using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.S22.E24.TableSplitting;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string ImageUrl { get; set; }
    public NewsDetail? NewsDetail { get; set; }
}

public class NewsDetail
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Body { get; set; }
}