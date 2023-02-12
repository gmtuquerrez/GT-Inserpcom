using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProjectBLL;
using TestProjectDAL.Entity;

namespace WebApplicationTestProject.Controllers
{
    [Authorize]
    [RoutePrefix("api/data")]
    public class DataAccessController : ApiController
    {
        [HttpGet]
        [Route("us-daily-find-all")]
        public List<UsDailyDAO> UsDailyGetAll()
        {
            return new DailyBLL().FindAllUsDailyDAL();
        }

        [HttpGet]
        [Route("state-daily-find-all")]
        public List<StateDailyDAO> StateDailyGetAll()
        {
            return new DailyBLL().FindAllStateDailyDAL();

        }
    }
}
