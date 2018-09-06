using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Model
{
    public class StudentDataModel
    {
        public static List<StudentDataDetailsModel> GetStudentData()
        {
            return new List<StudentDataDetailsModel>
            {
                new StudentDataDetailsModel
                {
                    ID = 1,
                    Name = "Akash",
                    Class = 8,
                    Age = 14
                },
                new StudentDataDetailsModel
                {
                    ID = 2,
                    Name = "Gaurav",
                    Class = 7,
                    Age = 13
                },
                new StudentDataDetailsModel
                {
                    ID = 3,
                    Name = "Himanshu",
                    Class = 10,
                    Age = 15
                },
                new StudentDataDetailsModel
                {
                    ID = 4,
                    Name = "Sudhanshu",
                    Class = 12,
                    Age = 18
                },
                new StudentDataDetailsModel
                {
                    ID = 5,
                    Name = "Sharthak",
                    Class = 5,
                    Age = 10
                },
                new StudentDataDetailsModel
                {
                    ID = 6,
                    Name = "Rohit",
                    Class = 4,
                    Age = 9
                },
                new StudentDataDetailsModel
                {
                    ID = 7,
                    Name = "Shakib",
                    Class = 9,
                    Age = 14
                },
                new StudentDataDetailsModel
                {
                    ID = 8,
                    Name = "ShakibAkhtar",
                    Class = 10,
                    Age = 17
                }


            };
        }
    }
}
