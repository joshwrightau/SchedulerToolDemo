namespace ScheduleLogic.Models
{
    using System.Collections.Generic;
    using GalaSoft.MvvmLight;

    public class Team : ViewModelBase
    {
        private int _id;
        private string _name;
        private long _teamLeader;
        private bool _isActive;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            EmployeeToTeamMaps = new HashSet<EmployeeToTeamMap>();
        }

        public int Id
        {
            get => _id;
            set
            {
                if(_id == value) return;

                _id = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if(_name == value) return;
                    
                _name = value;
                RaisePropertyChanged();
            }
        }

        public long TeamLeader
        {
            get => _teamLeader;
            set
            {
                if(_teamLeader == value) return;

                _teamLeader = value;
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

        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeToTeamMap> EmployeeToTeamMaps { get; }
    }
}
