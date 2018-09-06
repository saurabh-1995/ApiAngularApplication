using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Model
{
    public class StudentJoinDetailsModel
    {
        public List<DataAndTranscationsModel> studentJoinResultSet
        {
            set; get;
        }

        public static implicit operator List<object>(StudentJoinDetailsModel v)
        {
            throw new NotImplementedException();
        }
    }
}
