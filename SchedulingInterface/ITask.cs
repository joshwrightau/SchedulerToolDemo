using System;
using System.Collections.Generic;

namespace ScheduleInterface
{
    public interface ITask
    {
        Employee Employees { get; set; }
        decimal HoursEstimated { get; set; }
        decimal HoursScheduled { get; set; }
        long Id { get; set; }
        bool IsActive { get; set; }
        int PriorityId { get; set; }
        PriorityLevel PriorityLevel { get; set; }
        long Resource { get; set; }
        DateTime ScheduledUtc { get; set; }
        int StatusId { get; set; }
        TaskStatus TaskStatuses { get; set; }
        TaskType TaskTypes { get; set; }
        int TypeId { get; set; }
        ICollection<Utilization> Utilization { get; }
        long WorkRequestId { get; set; }
        WorkRequest WorkRequests { get; set; }
    }
}