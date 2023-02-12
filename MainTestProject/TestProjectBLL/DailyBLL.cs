using System.Collections.Generic;
using TestProjectDAL;
using TestProjectDAL.Entity;

namespace TestProjectBLL
{
    public class DailyBLL
    {
        public List<UsDailyDAO> FindAllUsDailyDAL()
        {
            return new DailyDAL().FindAllUsDailyDAL();
        }

        public List<StateDailyDAO> FindAllStateDailyDAL()
        {
            return new DailyDAL().FindAllStateDailyDAL();
        }
    }
}
