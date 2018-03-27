using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeEmployeeSet : FakeDbSet<Employee>
    {
        public override Employee Find(params object[] keyValues) => this.SingleOrDefault(e => e.Id == (long) keyValues.Single());
    }
}