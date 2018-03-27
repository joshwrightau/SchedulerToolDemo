using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeUtilizationSet : FakeDbSet<Utilization>
    {
        public override Utilization Find(params object[] keyValues)
            => this.SingleOrDefault(u => u.Id == (long) keyValues.First());
    }
}
