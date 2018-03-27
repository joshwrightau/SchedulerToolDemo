using System.ComponentModel;
using System.Runtime.CompilerServices;
using ScheduleLogic.Annotations;

namespace ScheduleLogic.Models
{
    using GalaSoft.MvvmLight;
    using System.Collections.Generic;

    public class WorkRequest : ViewModelBase
    {
        private long _id;
        private string _name;
        private string _description;
        private bool _isActive;
        private long _owner;
        private string _externalLink;
        private string _client;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkRequest()
        {
            Tasks = new HashSet<Task>();
            Utilizations = new HashSet<Utilization>();
        }

        public string Client
        {
            get => _client;
            set
            {
                if(_client == value) return;
                
                _client = value;
                OnPropertyChanged();
            }
        }

        public long Id
        {
            get => _id;
            set
            {
                if(_id == value) return;

                _id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if(_name == value) return;

                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if(_description == value) return;

                _description = value;
                OnPropertyChanged();
            }
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if(_isActive == value) return;

                _isActive = value;
                OnPropertyChanged();
            }
        }

        public long Owner
        {
            get => _owner;
            set
            {
                if(_owner == value) return;

                _owner = value;
                OnPropertyChanged();
            }
        }

        public string ExternalLink
        {
            get => _externalLink;
            set
            {
                if(_externalLink == value) return;

                _externalLink = value;
                OnPropertyChanged();
            }
        }

        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilization> Utilizations { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
