using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakePriorityLevelSet : FakeDbSet<PriorityLevel>
    {
        public override PriorityLevel Find(params object[] keyValues) =>
            this.SingleOrDefault(p => p.Id == (int) keyValues.First());
    }
}
