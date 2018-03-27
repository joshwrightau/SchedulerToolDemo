using System.Collections.Generic;

namespace ScheduleInterface
{
    public interface ITeam
    {
        Employee Employee { get; set; }
        ICollection<EmployeeToTeamMap> EmployeeToTeamMaps { get; }
        int Id { get; set; }
        bool IsActive { get; set; }
        string Name { get; set; }
        long TeamLeader { get; set; }
    }
}