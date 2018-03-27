namespace ScheduleLogic.Models
{
    using GalaSoft.MvvmLight;

    public class Utilization : ViewModelBase
    {
        private long _id;
        private long _workRequestId;
        private long? _taskId;
        private int _taskTypeId;
        private decimal _hours;

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

        public long? TaskId
        {
            get => _taskId;
            set
            {
                if(_taskId == value) return;

                _taskId = value;
                RaisePropertyChanged();
            }
        }

        public int TaskTypeId
        {
            get => _taskTypeId;
            set
            {
                if(_taskTypeId == value) return;

                _taskTypeId = value;
                RaisePropertyChanged();
            }
        }

        public decimal Hours
        {
            get => _hours;
            set
            {
                if(_hours == value) return;

                _hours = value;
                RaisePropertyChanged();
            }
        }

        public virtual Task Task { get; set; }
        public virtual TaskType TaskType { get; set; }
        public virtual WorkRequest WorkRequest { get; set; }
    }
}
