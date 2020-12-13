using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Domain.AutoMapper
{
    public class ServiceMappings : Profile
    {
        public ServiceMappings()
        {
            CreateMap<Database.Articles, Domain.Articles>();
            CreateMap<Database.TagCloud, Domain.TagCloud>();
        }

    }
}
