using System.Linq;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeTeamSet : FakeDbSet<Team>
    {
        public override Team Find(params object[] keyValues)
            => this.SingleOrDefault(t => t.Id == (long) keyValues.First());

    }
}
