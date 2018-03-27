using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeWorkRequestSet : FakeDbSet<WorkRequest>
    {
        public override WorkRequest Find(params object[] keyValues)
            => this.SingleOrDefault(w => w.Id == (long) keyValues.First());
    }
}
