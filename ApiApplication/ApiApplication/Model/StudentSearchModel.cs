using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Model
{
    public class StudentSearchModel
    {
        public string SearchByCategory
        {
            set; get;
        }
        public string SearchByText
        {
            get; set;
        }
        public string OrderByCategory
        {
            get; set;
        }
        public int MinRange
        {
            set; get;
        }
        public int MaxRange
        {
            set; get;
        }
    }
}
