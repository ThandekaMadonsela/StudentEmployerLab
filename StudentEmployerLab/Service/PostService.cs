using StudentEmployerLab.Interfaces;
using StudentEmployerLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEmployerLab.Data;
using StudentEmployerLab.Models.Utilities;

namespace StudentEmployerLab.Service
{
    public  class PostService : IPostService

    {
        Post IPostService.CreatePost(IEmployer employer)
        {
            var randomIndex = Util.Random.Next(20);
            Post post = new Post(employer,Data.Data.CompanyNames[randomIndex] ,Data.Data.JobDescription[randomIndex],
                        Data.Data.Department[randomIndex], Data.Data.StartDates[randomIndex], Data.Data.Rates[randomIndex]);

            return post;
        }
    
    }
}
