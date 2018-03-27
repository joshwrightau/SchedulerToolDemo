using System.Collections.Generic;

namespace ScheduleInterface
{
    public interface IWorkRequest
    {
        string Description { get; set; }
        Employee Employee { get; set; }
        string ExternalLink { get; set; }
        long Id { get; set; }
        bool IsActive { get; set; }
        string Name { get; set; }
        long Owner { get; set; }
        ICollection<Task> Tasks { get; }
        ICollection<Utilization> Utilizations { get; }
    }
}