using System.Data.Entity;
using ScheduleInterface;

namespace SchedulingInterface
{
    public interface IEntities<TEmployee, TEmployeeToTeamMap, TPriorityLevel, TTask, TTaskStatus, TTeam, TUtilization, TWorkRequest, TTaskType>
        where
    {
        IDbSet<TEmployee> Employees { get; set; }
        IDbSet<TEmployeeToTeamMap> EmployeeToTeamMaps { get; set; }
        IDbSet<TPriorityLevel> PriorityLevels { get; set; }
        IDbSet<TTask> Tasks { get; set; }
        IDbSet<TTaskStatus> TaskStatus { get; set; }
        IDbSet<TTaskType> TaskTypes { get; set; }
        IDbSet<TTeam> Teams { get; set; }
        IDbSet<TUtilization> Utilizations { get; set; }
        IDbSet<TWorkRequest> WorkRequests { get; set; }
    }
}