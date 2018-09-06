using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiApplication.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public StudentJoinDetailsModel Get()
        {
            List<StudentDataDetailsModel> studentDetails = StudentDataModel.GetStudentData();
            List<StudentTranscationsDetailsModel> studentTranscationsDetails = StudentTransactionsModel.GetStudentTranscationData();
            List<DataAndTranscationsModel> studentJoinResult = (from data in studentDetails
                                                                join transcation in studentTranscationsDetails
                                                                on data.ID equals transcation.ID
                                                                select new DataAndTranscationsModel
                                                                {
                                                                    ID = data.ID,
                                                                    Name = data.Name,
                                                                    Fees = transcation.Fees,
                                                                    Class = data.Class,
                                                                    Date = transcation.Date,
                                                                    Age = data.Age
                                                                }).ToList();
            StudentJoinDetailsModel sendJoinResults = new StudentJoinDetailsModel();
            sendJoinResults.studentJoinResultSet = studentJoinResult;
            return sendJoinResults ;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Value> Get(int id)
        {
            return new Value {id=id,text="value" };
        }

        // POST api/values
        [HttpPost] 
        public List<DataAndTranscationsModel>Post([FromBody] StudentSearchModel studentSearchModel)
        {
            StudentJoinSearchModel studentResult = new StudentJoinSearchModel();
            List<DataAndTranscationsModel> studentAllDetails = studentResult.SearchStudentData(studentSearchModel);
            return studentAllDetails;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Value
    {
        public int id { get; set; }
        public string text { get; set; }  
    }
}
