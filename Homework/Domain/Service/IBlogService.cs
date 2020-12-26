using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Domain
{
    public interface IBlogService
    {
        List<Articles> GetArticles();

        IPagedList<Articles> GetArticles(int page, int pageSize);

        IPagedList<Articles> GetArticles(string searchKeyWord,int page, int pageSize);
    }
}
