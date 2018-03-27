using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using ScheduleLogic.Helpers;
using ScheduleLogic.Models;

namespace SchedulerTool.ViewModels
{
    public class WorkRequestViewModel : WorkRequest
    {
        private bool _isSaving;
        private bool _isSavingComplete;
        private bool _isWorkingLink;

        public WorkRequestViewModel(WorkRequest baseWorkRequest)
        {
            PropertyChanged += (obj, args) =>
                               {
                                   if (args.PropertyName.Equals(nameof(ExternalLink))) // Listen for changes to the Link
                                       RaisePropertyChanged(nameof(LinkEnabled));
                               };

            Id           = baseWorkRequest.Id;
            Description  = baseWorkRequest.Description;
            ExternalLink = baseWorkRequest.ExternalLink;
            IsActive     = baseWorkRequest.IsActive;
            Name         = baseWorkRequest.Name;
            Owner        = baseWorkRequest.Owner;
            Client       = baseWorkRequest.Client;
            TaskList     = new ObservableCollection<Task>(baseWorkRequest.Tasks.ToList());
        }

        private ObservableCollection<Task> _taskList;

        public ObservableCollection<Task> TaskList
        {
            get => _taskList;
            private set
            {
                if (_taskList == value) return;

                _taskList = value;
                RaisePropertyChanged();
            }
        }

        public bool IsWorkingLink
        {
            get => _isWorkingLink;
            set
            {
                if (_isWorkingLink == value) return;

                _isWorkingLink = value;
                RaisePropertyChanged();
            }
        }

        public bool IsSaving
        {
            get => _isSaving;
            set
            {
                if (_isSaving == value) return;

                _isSaving = value;
                RaisePropertyChanged();
            }
        }

        public bool IsSavingComplete
        {
            get => _isSavingComplete;
            set
            {
                if (_isSavingComplete == value) return;

                _isSavingComplete = value;
                RaisePropertyChanged();
            }
        }

        public bool LinkEnabled => ExternalLink != null;

        public ICommand OpenCommand => new RelayCommand(() => OpenLink(ExternalLink), ExternalLink != null);

        //public ObservableCollection<Task> TaskList => (ObservableCollection<Task>) Tasks;

        public ICommand SaveCommand => new RelayCommand(SaveReport);

        private static void OpenLink(string link)
        {
            System.Threading.Tasks.Task.Run(() => Process.Start(new ProcessStartInfo(link)));
        }

        private void SaveReport()
        {
            try
            {
                var filename = $"{Name}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

                var sfdiag = new SaveFileDialog
                             {
                                 AddExtension = true,
                                 Filter       = "Excel Workbook (*.xlsx)|*.xlsx",
                                 DefaultExt   = "xlsx",
                                 FileName     = filename
                             };

                if (sfdiag.ShowDialog() == true)
                {
                    FileSaver.SaveFile(filename, ReportGenerator.GenerateExport(this));

                    MessengerInstance.Send(new GenericMessage<Report>(new Report
                                                                      {
                                                                          Filename     = filename,
                                                                          FullFilePath = sfdiag.FileName
                                                                      }));

                    IsSaving         = false;
                    IsSavingComplete = true;
                }
                else
                {
                    IsSaving         = false;
                    IsSavingComplete = false;
                }
            }
            catch (Exception ex)
            {
                MessengerInstance.Send(new GenericMessage<Exception>(ex));
            }
        }
    }
}