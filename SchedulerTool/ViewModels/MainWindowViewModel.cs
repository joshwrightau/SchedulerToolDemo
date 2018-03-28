using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using ScheduleLogic.Models;
using SchedulerTool.Models;
using SchedulerTool.Views;
using MenuItem = SchedulerTool.Models.MenuItem;
using Task = System.Threading.Tasks.Task;

namespace SchedulerTool.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private const string BaseTitle = "Scheduler";

        private bool                           _isHamburgerMenuChecked;
        private bool                           _isLeftDrawerOpen;
        private ObservableCollection<MenuItem> _menuItems = new ObservableCollection<MenuItem>();
        private MenuItem                       _selectedMenuItem;
        private WindowState                    _windowState;

        private JobSearchViewModel JobSearchViewModel { get; set; } = new JobSearchViewModel();

        public MainWindowViewModel()
        {
            MessengerInstance.Register<GenericMessage<Report>>(this, NotifyReport);
            MessengerInstance.Register<GenericMessage<Exception>>(this, NotifyException);
            MessengerInstance.Register<NotificationMessage>(this, Notify);

            MenuItems.Add(new MenuItem
                          {
                              Content                    = new JobSearchView(JobSearchViewModel),
                              Name                       = "Job Search",
                              DisplayHorizontalScrollbar = ScrollBarVisibility.Disabled,
                              DisplayVerticalScrollbar   = ScrollBarVisibility.Auto,
                              MarginThickness            = new Thickness(16),
                              Documentation = new[]
                                                   {
                                                       new DocumentationLink
                                                       {
                                                           Label =
                                                               "Get Help!",
                                                           Type =
                                                               DocumentationLinkTypes
                                                                  .Other,
                                                           Url =
                                                               "mailto:josh@wright.codes?subject=Send Help - Job Search page"
                                                       }
                                                   }
                          });

            SelectedMenuItem = MenuItems.FirstOrDefault();
        }

        public SnackbarMessageQueue MessageQueue { get; set; } = new SnackbarMessageQueue();

        public bool IsLeftDrawerOpen
        {
            get => _isLeftDrawerOpen;
            set
            {
                if (_isLeftDrawerOpen == value) return;

                _isLeftDrawerOpen = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<MenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                if (_menuItems == value) return;

                _menuItems = value;
                RaisePropertyChanged();
            }
        }

        public MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (_selectedMenuItem == value) return;

                _selectedMenuItem = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ApplicationTitle));
            }
        }

        public WindowState WindowState
        {
            get => _windowState;
            set
            {
                if (_windowState == value) return;

                _windowState = value;
                RaisePropertyChanged();
            }
        }

        public string ApplicationTitle =>
            SelectedMenuItem != null ? $"{BaseTitle} - {SelectedMenuItem.Name}" : BaseTitle;

        public ICommand HelpCommand =>
            new RelayCommand(() => OpenLink("mailto:josh@wright.codes?subject=I need help with the demo code!"));

        public ICommand MinimiseCommand =>
            new RelayCommand(() => WindowState = WindowState.Minimized);

        public ICommand CloseCommand =>
            new RelayCommand(() => Application.Current.Shutdown());

        private void NotifyException(GenericMessage<Exception> msg)
        {
            MessageQueue
               .Enqueue("Bugger! We weren't able to complete that request. Check the log for more information");
        }

        private void NotifyReport(GenericMessage<Report> msg)
        {
            MessageQueue.Enqueue($"Report Generated: {msg.Content.Filename}", "OPEN",
                                 () => OpenLink(msg.Content.FullFilePath));
        }

        private void Notify(NotificationMessage msg)
        {
            MessageQueue.Enqueue(msg.Notification);
        }

        private void OpenLink(string link)
        {
            try
            {
                Task.Run(() => Process.Start(new ProcessStartInfo(link)));
            }
            catch (Exception ex)
            {
                MessengerInstance.Send(new GenericMessage<Exception>(ex));
            }
        }
    }
}