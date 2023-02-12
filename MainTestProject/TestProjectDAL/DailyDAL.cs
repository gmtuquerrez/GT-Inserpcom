using System.Collections.Generic;
using System.Linq;
using TestProjectDAL.Entity;

namespace TestProjectDAL
{
    public class DailyDAL
    {
        private TestProjectEntities ctx = new TestProjectEntities();
        public List<UsDailyDAO> FindAllUsDailyDAL()
        {
            List<UsDailyDAO> response = new List<UsDailyDAO>();

            var listData = ctx.UsDailies.ToList();

            foreach (var item in listData)
            {
                response.Add(new UsDailyDAO(item));
            }


            return response;
        }

        public List<StateDailyDAO> FindAllStateDailyDAL()
        {

            List<StateDailyDAO> response = new List<StateDailyDAO>();

            var listData = ctx.StatesDailies.ToList();

            foreach (var item in listData)
            {
                response.Add(new StateDailyDAO(item));
            }

            return response;
        }
    }
}
