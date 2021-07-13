using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI.Models
{
    class SearchResult<T>
    {
        //Count
        public int Count { get; set; }
        //Results
        public List<T> Results { get; set; } = new List<T>();
    }
}
