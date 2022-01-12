using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPILearning2.RequestModels;
using WEBAPILearning2.Repository;

namespace WEBAPILearning2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
               
        //GET api/values

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Student Request)
        {
            StudentRepository.PostStudentData(Request);
        }
        [HttpGet]
        public Student get(int id)
        {
            return  StudentRepository.GetStudentData(id);
        }


        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

    }
}
