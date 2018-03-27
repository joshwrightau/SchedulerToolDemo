namespace ScheduleLogic.Models
{
    using System.Collections.Generic;
    using GalaSoft.MvvmLight;

    public class TaskStatus : ViewModelBase
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _isActive;
        private string _backgroundColour;
        private string _foregroundColour;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskStatus()
        {
            Tasks = new HashSet<Task>();
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
    }
}

