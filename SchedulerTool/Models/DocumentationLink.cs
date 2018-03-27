using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace SchedulerTool.Models
{
    public class DocumentationLink : ViewModelBase
    {
        private string                 _label;
        private DocumentationLinkTypes _type;
        private string                 _url;

        public string Label
        {
            get => _label;
            set
            {
                if (_label== value) return;

                _label = value;
                RaisePropertyChanged();
            }
        }

        public ICommand Open => new RelayCommand(() => OpenLink(Url), CanOpenLink);

        public DocumentationLinkTypes Type
        {
            get => _type;
            set
            {
                if (_type== value) return;

                _type = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(CanOpenLink));
            }
        }

        public string Url
        {
            get => _url;
            set
            {
                if (_url== value) return;

                _url = value;
                RaisePropertyChanged();
            }
        }

        public bool CanOpenLink => Url == null;

        private void OpenLink(string link)
        {
            Task.Run(() => Process.Start(new ProcessStartInfo(link)));
        }
    }

    public enum DocumentationLinkTypes
    {
        Jira,
        Confluence,
        Sharepoint,
        Youtube,
        Other
    }
}