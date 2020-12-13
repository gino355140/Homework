using Homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Models
{
    public class BlogViewModel
    {
        public BlogViewModel() { ArticlesList = new List<Articles>(); }

        public List<Articles> ArticlesList { get; set; }

        public TagCloud TagCloud { get; set; }

    }
}
