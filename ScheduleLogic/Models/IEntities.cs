using System.Data.Entity;
using ScheduleLogic.Models;

namespace ScheduleLogic.Models
{
    public interface IEntities
    {
        IDbSet<Employee> Employees { get; set; }
        IDbSet<EmployeeToTeamMap> EmployeeToTeamMaps { get; set; }
        IDbSet<PriorityLevel> PriorityLevels { get; set; }
        IDbSet<Task> Tasks { get; set; }
        IDbSet<TaskStatus> TaskStatus { get; set; }
        IDbSet<TaskType> TaskTypes { get; set; }
        IDbSet<Team> Teams { get; set; }
        IDbSet<Utilization> Utilizations { get; set; }
        IDbSet<WorkRequest> WorkRequests { get; set; }
    }
}