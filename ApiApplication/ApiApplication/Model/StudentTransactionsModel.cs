using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Model
{
    public class StudentTransactionsModel
    {
        public static List<StudentTranscationsDetailsModel> GetStudentTranscationData()
        {
            return new List<StudentTranscationsDetailsModel>
            {
                new StudentTranscationsDetailsModel
                {
                    ID = 1,
                    Fees = 2000,
                    Date = "14 Jan"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 2,
                    Fees = 3000,
                    Date = "13 July"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 3,
                    Fees = 3500,
                    Date = "15 June"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 4,
                    Fees = 4000,
                    Date = "18 March"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 5,
                    Fees = 3500,
                    Date = "30 Jan"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 6,
                    Fees = 1700,
                    Date = "17 March"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 7,
                    Fees = 3900,
                    Date = "10 Dec"
                },
                new StudentTranscationsDetailsModel
                {
                    ID = 8,
                    Fees = 5000,
                    Date = "18 Feb"
                }
            };
        }
    }
}
