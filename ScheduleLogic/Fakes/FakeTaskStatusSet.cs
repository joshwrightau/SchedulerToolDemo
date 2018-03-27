using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeTaskStatusSet : FakeDbSet<TaskStatus>
    {
        public override TaskStatus Find(params object[] keyValues)
            => this.SingleOrDefault(t => t.Id == (int) keyValues.First());
    }
}
