using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;

namespace SchedulerTool.Models
{
    public class MenuItem : ViewModelBase
    {
        private object                         _content;
        private ScrollBarVisibility            _displayHorizontalScrollbar;
        private ScrollBarVisibility            _displayVerticalScrollbar;
        private IEnumerable<DocumentationLink> _documentationLinks;
        private Thickness                      _marginThickness;
        private string                         _name;

        public object Content
        {
            get => _content;
            set
            {
                _content = value;
                RaisePropertyChanged();
            }
        }

        public IEnumerable<DocumentationLink> DocumentationLinks
        {
            get => _documentationLinks;
            set
            {
                if (_documentationLinks.Equals(value)) return;

                _documentationLinks = value;
                RaisePropertyChanged();
            }
        }

        public ScrollBarVisibility DisplayHorizontalScrollbar
        {
            get => _displayHorizontalScrollbar;
            set
            {
                if (_displayHorizontalScrollbar == value) return;

                _displayHorizontalScrollbar = value;
                RaisePropertyChanged();
            }
        }

        public ScrollBarVisibility DisplayVerticalScrollbar
        {
            get => _displayVerticalScrollbar;
            set
            {
                if (_displayVerticalScrollbar == value) return;

                _displayVerticalScrollbar = value;
                RaisePropertyChanged();
            }
        }

        public Thickness MarginThickness
        {
            get => _marginThickness;
            set
            {
                if (_marginThickness == value) return;

                _marginThickness = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;

                _name = value;
                RaisePropertyChanged();
            }
        }
    }
}