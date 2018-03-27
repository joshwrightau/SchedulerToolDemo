namespace ScheduleLogic.Models
{
    using System.Collections.Generic;
    using System;
    using GalaSoft.MvvmLight;

    public class Task : ViewModelBase
    {
        private long _id;
        private long _workRequestId;
        private decimal _hoursEstimated;
        private decimal _hoursScheduled;
        private DateTime _scheduledUtc;
        private bool _isActive;
        private int _typeId;
        private int _statusId;
        private int _priorityId;
        private long _resource;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Utilization = new HashSet<Utilization>();
        }

        public long Id
        {
            get => _id;
            set
            {
                if(_id == value) return;

                _id = value;
                RaisePropertyChanged();
            }
        }

        public long WorkRequestId
        {
            get => _workRequestId;
            set
            {
                if(_workRequestId == value) return;

                _workRequestId = value;
                RaisePropertyChanged();
            }
        }

        public decimal HoursEstimated
        {
            get => _hoursEstimated;
            set
            {
                if(_hoursEstimated == value) return;

                _hoursEstimated = value;
                RaisePropertyChanged();
            }
        }

        public decimal HoursScheduled
        {
            get => _hoursScheduled;
            set
            {
                if(_hoursEstimated == value) return;
                
                _hoursScheduled = value;
                RaisePropertyChanged();
            }
        }

        public DateTime ScheduledUtc
        {
            get => _scheduledUtc;
            set
            {
                if(_scheduledUtc == value) return;

                _scheduledUtc = value;
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

        public int TypeId
        {
            get => _typeId;
            set
            {
                if(_typeId == value) return;
                
                _typeId = value;
                RaisePropertyChanged();
            }
        }

        public int StatusId
        {
            get => _statusId;
            set
            {
                if(_statusId == value) return;

                _statusId = value;
                RaisePropertyChanged();
            }
        }

        public int PriorityId
        {
            get => _priorityId;
            set
            {
                if(_priorityId == value) return;

                _priorityId = value;
                RaisePropertyChanged();
            }
        }

        public long Resource
        {
            get => _resource;
            set
            {
                if(_resource == value) return;

                _resource = value;
                RaisePropertyChanged();
            }
        }

        public virtual Employee Employees { get; set; }
        public virtual PriorityLevel PriorityLevel { get; set; }
        public virtual TaskStatus TaskStatuses { get; set; }
        public virtual TaskType TaskTypes { get; set; }
        public virtual WorkRequest WorkRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilization> Utilization { get; }
    }
}
