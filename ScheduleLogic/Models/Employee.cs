namespace ScheduleLogic.Models
{
    using System.Collections.Generic;
    using GalaSoft.MvvmLight;

    public class Employee : ViewModelBase
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private bool _isActive;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            EmployeeToTeamMaps = new HashSet<EmployeeToTeamMap>();
            Tasks = new HashSet<Task>();
            Teams = new HashSet<Team>();
            WorkRequests = new HashSet<WorkRequest>();
        }

        public long Id
        {
            get => _id;
            set
            {
                if (_id== value) return;

                _id = value;
                RaisePropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName== value) return;

                _firstName = value;
                RaisePropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName== value) return;

                _lastName = value;
                RaisePropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if(_email== value) return;

                _email = value;
                RaisePropertyChanged();
            }
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if(_isActive== value) return;

                _isActive= value;
                RaisePropertyChanged();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeToTeamMap> EmployeeToTeamMaps { get; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Team> Teams { get; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkRequest> WorkRequests { get; }
    }
}
