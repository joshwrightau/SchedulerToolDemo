

namespace DataAccess.Entities
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using ScheduleLogic.Models;

    public class Entities : DbContext, IEntities
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual IDbSet<Employee> Employees { get; set; }
        public virtual IDbSet<EmployeeToTeamMap> EmployeeToTeamMaps { get; set; }
        public virtual IDbSet<PriorityLevel> PriorityLevels { get; set; }
        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<TaskStatus> TaskStatus { get; set; }
        public virtual IDbSet<TaskType> TaskTypes { get; set; }
        public virtual IDbSet<Team> Teams { get; set; }
        public virtual IDbSet<Utilization> Utilizations { get; set; }
        public virtual IDbSet<WorkRequest> WorkRequests { get; set; }
    }
}
