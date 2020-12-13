using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Domain
{
    public interface IBlogService
    {
        List<Articles> GetArticles();
    }
}
