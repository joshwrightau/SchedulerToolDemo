namespace SchedulingInterface
{
    public interface IEmployeeToTeamMap<TEmployee, TTeam>
        where TTeam : ITeam
    {
        long Employee { get; set; }
        TTeam EmployeeToTeam { get; set; }
        bool IsActive { get; set; }
        int Team { get; set; }
        TEmployee TeamToEmployee { get; set; }
    }
}