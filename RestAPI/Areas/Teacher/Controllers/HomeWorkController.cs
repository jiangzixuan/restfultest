using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RestAPI.Areas.Teacher.Controllers
{
    //[RoutePrefix("teacher/homework")]
    public class HomeWorkController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "getall";
        }
        [HttpGet]
        public string Get(int id)
        {
            return "get_" + id;
        }


        public void Delete(int id)
        {

        }

        public string Put(int id)
        {
            return "put_" + id;
        }

        public string Post(int id)
        {
            return "post_" + id;
        }
    }
}