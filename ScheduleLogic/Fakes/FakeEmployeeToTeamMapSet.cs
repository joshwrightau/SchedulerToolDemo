using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeEmployeeToTeamMapSet : FakeDbSet<EmployeeToTeamMap>
    {
        public override EmployeeToTeamMap Find(params object[] keyValues) =>
            this.SingleOrDefault(e => e.Employee == (long) keyValues[0] && e.Team == (long) keyValues[1]);
    }
}