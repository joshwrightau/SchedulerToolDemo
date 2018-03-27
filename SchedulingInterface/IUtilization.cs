namespace ScheduleInterface
{
    public interface IUtilization
    {
        decimal Hours { get; set; }
        long Id { get; set; }
        Task Task { get; set; }
        long? TaskId { get; set; }
        TaskType TaskType { get; set; }
        int TaskTypeId { get; set; }
        WorkRequest WorkRequest { get; set; }
        long WorkRequestId { get; set; }
    }
}