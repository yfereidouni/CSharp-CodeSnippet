using iEFCore.TableSplitting;
using Microsoft.EntityFrameworkCore;

TableSplittingDbContext ctx = new TableSplittingDbContext();

//News news = new News 
//{ 
//    ImageUrl ="Url",
//    ShortDescription = "Description",
//    Title= "Title",
//    NewsDetail= new NewsDetail 
//    {
//        Body ="Body"
        
//    }
//};

//ctx.Add(news);
//ctx.SaveChanges();

var newsList = ctx.News.Include(c=>c.NewsDetail).ToList();
Console.ReadLine();


