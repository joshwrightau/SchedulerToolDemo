namespace ScheduleLogic.Models
{
    using GalaSoft.MvvmLight;

    public class EmployeeToTeamMap : ViewModelBase
    {
        private long _employee;
        private int _team;
        private bool _isActive;

        public long Employee
        {
            get => _employee; set
            {
                if(_employee == value) return;

                _employee = value;
                RaisePropertyChanged();
            }
        }

        public int Team
        {
            get => _team;
            set
            {
                if(_team == value) return;

                _team = value;
                RaisePropertyChanged();
            }
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if(_isActive == value) return;

                _isActive = value;
                RaisePropertyChanged();
            }
        }

        public virtual Employee TeamToEmployee { get; set; }
        public virtual Team EmployeeToTeam { get; set; }
    }
}
