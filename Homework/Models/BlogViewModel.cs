using Homework.Domain;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Models
{
    public class BlogViewModel
    {
        public BlogViewModel()
        {
            VisiblePage = 5;
        }

        public IPagedList<Articles> ArticlesList { get; set; }

        public TagCloud TagCloud { get; set; }

        public int TotalAcount { get; set; }

        public int VisiblePage { get; set; }
    }
}
