using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeTaskTypeSet : FakeDbSet<TaskType>
    {
        public override TaskType Find(params object[] keyValues) => this.SingleOrDefault(t => t.Id == (int) keyValues.First());
    }
}
