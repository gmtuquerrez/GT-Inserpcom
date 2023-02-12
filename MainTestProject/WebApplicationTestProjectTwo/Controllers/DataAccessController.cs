using System.Collections.Generic;
using System.Web.Http;
using TestProjectBLL;
using TestProjectDAL.Entity;

namespace WebApplicationTestProjectTwo.Controllers
{
    [Authorize]
    [RoutePrefix("api/data")]
    public class DataAccessController : ApiController
    {
        [HttpGet]
        [Route("state-daily-find-all")]
        public List<StateDailyDAO> StateDailyGetAll()
        {
            return new DailyBLL().FindAllStateDailyDAL();

        }
    }
}
