using Homework.Domain;
using Homework.Domain.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Database
{
    public class BlogService : IBlogService
    {
        public readonly BlogDbContext _dbContext;

        public BlogService(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Domain.Articles> GetArticles()
        {
            var daoArticles = _dbContext.Articles.ToList();
            var config = new AutoMapper.MapperConfiguration(cfg => cfg.AddProfile<ServiceMappings>());
            var mapper = config.CreateMapper(); // 用設定檔建立 Mapper
            var result = mapper.Map<IEnumerable<Domain.Articles>>(daoArticles).ToList(); // 轉換型別

            return result;
        }
    }
}
