using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Database
{
    public class Articles
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string CoverPhoto { get; set; }

        public DateTime CreateDate { get; set; }

        public string Tags { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}
