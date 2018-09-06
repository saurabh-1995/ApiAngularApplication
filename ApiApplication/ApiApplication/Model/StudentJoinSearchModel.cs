using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Model
{
    public class StudentJoinSearchModel
    {
        public List<DataAndTranscationsModel> SearchStudentData(StudentSearchModel searchData)
        {
            if (searchData.MaxRange == 0)
            {
                searchData.MaxRange = 999999999;
            }
            List<StudentDataDetailsModel> studentDataDetails = StudentDataModel.GetStudentData();
            List<StudentTranscationsDetailsModel> studentTranscationsDetailsModels = StudentTransactionsModel.GetStudentTranscationData();
            var dataAndTranscationsModels = (from data in studentDataDetails
                                             join transcations in studentTranscationsDetailsModels
                                             on data.ID equals transcations.ID
                                             where IsCategory(data,
                                             searchData.SearchByCategory,
                                             searchData.SearchByText)
                                             && (transcations.Fees >= searchData.MinRange && transcations.Fees
                                             <= searchData.MaxRange)
                                             select new DataAndTranscationsModel
                                             {
                                                 ID = data.ID,
                                                 Name = data.Name,
                                                 Class = data.Class,
                                                 Age = data.Age,
                                                 Fees = transcations.Fees,
                                                 Date = transcations.Date
                                             }).ToList();
            StudentJoinDetailsModel studentJoinDetailsModel = new StudentJoinDetailsModel();
            studentJoinDetailsModel.studentJoinResultSet = Sort(dataAndTranscationsModels, searchData.OrderByCategory);
            return studentJoinDetailsModel.studentJoinResultSet;
        }

        private bool IsCategory(StudentDataDetailsModel studentDataDetails, string searchByCategory, string searchByText)
        {
            if (searchByCategory == "Name")
            {
                if (studentDataDetails.Name == searchByText)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            if (searchByCategory == "Class")
            {
                int number;
                if (!int.TryParse(searchByText, out number))
                    return false;
                if (studentDataDetails.Class == Convert.ToInt64(searchByText))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (searchByCategory == "ID")
            {
                int number;
                if (!int.TryParse(searchByText, out number))
                    return false;

                if (studentDataDetails.ID == Convert.ToInt64(searchByText))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private List<DataAndTranscationsModel> Sort(List<DataAndTranscationsModel> studentDataDetails, string orderByCategory)
        {
            if (orderByCategory == "ID")
                studentDataDetails = (from studentobject in studentDataDetails
                                      orderby studentobject.ID
                                      select studentobject).ToList();

            if (orderByCategory == "Name")
                studentDataDetails = (from studentobject in studentDataDetails
                                      orderby studentobject.Name
                                      select studentobject).ToList();
            if (orderByCategory == "Class")
                studentDataDetails = (from studentobject in studentDataDetails
                                      orderby studentobject.Class
                                      select studentobject).ToList();

            return studentDataDetails;

        }
    }
}
