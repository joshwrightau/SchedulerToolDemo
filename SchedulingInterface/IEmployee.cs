using System.Collections.Generic;

namespace SchedulingInterface
{
    public interface IEmployee<TEmployeeToTeamMap, TTask, TTeam, TWorkRequest>
    {
        string Email { get; set; }
        ICollection<TEmployeeToTeamMap> EmployeeToTeamMaps { get; }
        string FirstName { get; set; }
        long Id { get; set; }
        bool IsActive { get; set; }
        string LastName { get; set; }
        ICollection<TTask> Tasks { get; }
        ICollection<TTeam> Teams { get; }
        ICollection<TWorkRequest> WorkRequests { get; }
    }
}