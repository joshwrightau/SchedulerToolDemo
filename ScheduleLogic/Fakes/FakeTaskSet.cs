using System.Linq;
using Task = ScheduleLogic.Models.Task;

namespace ScheduleLogic.Fakes
{
    public class FakeTaskSet : FakeDbSet<Task>
    {
        public override Task Find(params object[] keyValues) =>
            this.SingleOrDefault(t => t.Id == (int) keyValues.First());
    }
}
