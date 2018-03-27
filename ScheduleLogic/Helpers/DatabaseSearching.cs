using System.Collections.Generic;
using System.Linq;
using ScheduleLogic.Fakes;
using ScheduleLogic.Models;

namespace ScheduleLogic.Helpers
{
    public static class DatabaseSearching
    {
        public static IEnumerable<WorkRequest> SearchRequests(string input)
        {
            IEntities db = new FakeScheduleContext();

            var inputs = input.Split(';').Select(p => p.Trim()).ToArray();

            return db.WorkRequests.Where(wr => inputs.Contains(wr.Id.ToString()));
        }
    }
}