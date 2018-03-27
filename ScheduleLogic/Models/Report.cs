using System.ComponentModel;
using System.Runtime.CompilerServices;
using ScheduleLogic.Annotations;

namespace ScheduleLogic.Models
{
    public class Report : INotifyPropertyChanged
    {
        private string _filename;
        private string _fullFilePath;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Public Properties

        public string Filename
        {
            get => _filename;
            set
            {
                if (_filename == value) return;

                _filename = value;
                OnPropertyChanged();
            }
        }

        public string FullFilePath
        {
            get => _fullFilePath;
            set
            {
                if (_filename == value) return;

                _fullFilePath = value;
                OnPropertyChanged();
            }
        }

        #endregion Public Properties
    }
}