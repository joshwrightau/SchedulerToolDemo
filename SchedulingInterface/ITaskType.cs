using System.Collections.Generic;

namespace ScheduleInterface
{
    public interface ITaskType
    {
        string BackgroundColour { get; set; }
        string Description { get; set; }
        string ForegroundColour { get; set; }
        int Id { get; set; }
        bool IsActive { get; set; }
        string Name { get; set; }
        ICollection<Task> Tasks { get; }
        ICollection<Utilization> Utilizations { get; }
    }
}