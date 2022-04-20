using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Configurations.DAL
{
    public class NewsRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public NewsRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Remove(int removeBy, int id)
        {
            var news = applicationDbContext.News.FirstOrDefault(c=>c.NewsId == id);
            if (news != null)
            {
                applicationDbContext.Entry(news).Property<int>("DeleteBy").CurrentValue = removeBy;
                applicationDbContext.Entry(news).Property<bool>("IsDeleted").CurrentValue = true;
            }
        }

        public News GetNews(int id)
        {
            return applicationDbContext.News.FirstOrDefault(c => c.NewsId == id && EF.Property<bool>(c, "IsDeleted") == false);
        }
    }
}
