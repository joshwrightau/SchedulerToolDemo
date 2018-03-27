namespace ScheduleLogic.Models
{
    using System.Collections.Generic;
    using GalaSoft.MvvmLight;

    public class TaskType : ViewModelBase
    {
        private string _foregroundColour;
        private string _backgroundColour;
        private bool _isActive;
        private string _description;
        private string _name;
        private int _id;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskType()
        {
            Tasks = new HashSet<Task>();
            Utilizations = new HashSet<Utilization>();
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
                if(_name == value)
                    return;

                _name = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if(_description == value) return;

                _description = value;
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

        public string BackgroundColour
        {
            get => _backgroundColour;
            set
            {
                if(_backgroundColour == value) return;

                _backgroundColour = value;
                RaisePropertyChanged();
            }
        }

        public string ForegroundColour
        {
            get => _foregroundColour;
            set
            {
                if(_foregroundColour == value) return;

                _foregroundColour = value;
                RaisePropertyChanged();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilization> Utilizations { get; }
    }
}
