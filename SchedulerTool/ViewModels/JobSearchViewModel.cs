using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using ScheduleLogic.Helpers;

namespace SchedulerTool.ViewModels
{
    public class JobSearchViewModel : ViewModelBase
    {
        private bool                                       _isSearching;
        private string                                     _userSearchInput;
        private ObservableCollection<WorkRequestViewModel> _workRequests;

        public string UserSearchInput
        {
            get => _userSearchInput;
            set
            {
                if (_userSearchInput == value) return;

                _userSearchInput = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsSearchingEnabled));
            }
        }

        public bool IsSearching
        {
            get => _isSearching;
            set
            {
                if (_isSearching == value) return;

                _isSearching = value;
                RaisePropertyChanged();
            }
        }

        public bool IsSearchingEnabled => !string.IsNullOrWhiteSpace(UserSearchInput);


        public ICommand SearchCommand => new RelayCommand(Search, true);

        public ObservableCollection<WorkRequestViewModel> WorkRequests
        {
            get => _workRequests;
            set
            {
                if (_workRequests == value) return;

                _workRequests = value;
                RaisePropertyChanged();
            }
        }

        private void Search()
        {
            try
            {
                UserSearchInput = @"1000002; 1000003; 9999999";

                MessengerInstance
                   .Send(new NotificationMessage($"Ignoring user's input and using {UserSearchInput} for demonstration"));

                WorkRequests =
                    new ObservableCollection<WorkRequestViewModel>(DatabaseSearching
                                                                  .SearchRequests(UserSearchInput)
                                                                  .Select(r => new WorkRequestViewModel(r)));

                var distinctMatches = WorkRequests.Select(wr => wr.Id.ToString()).Distinct().ToArray();

                var unmatched = UserSearchInput.Split(';')
                                               .Select(q => q.Trim())
                                               .Where(q => !distinctMatches.Contains(q))
                                               .ToArray();

                if (WorkRequests.Count <= 0)
                    MessengerInstance.Send(new NotificationMessage($"No Matches Found for {UserSearchInput}"));
                else if (unmatched.Any())
                    MessengerInstance.Send(new
                                               NotificationMessage($"{WorkRequests.Count:N0} matches for your search requests. No matches for \"{string.Join("\"; \"", unmatched)}\""));
                else
                    MessengerInstance
                       .Send(new NotificationMessage($"{WorkRequests.Count:N0} matches for your search requests"));
            }
            catch (Exception ex)
            {
                MessengerInstance.Send(new GenericMessage<Exception>(ex));
            }
        }
    }
}