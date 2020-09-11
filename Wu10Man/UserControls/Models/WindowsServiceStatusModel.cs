﻿namespace WereDev.Utils.Wu10Man.UserControls.Models
{
    public class WindowsServiceStatusModel : ModelBase
    {
        private string _serviceName = null;
        private string _displayName = null;
        private bool _isServiceEnabled = false;
        private bool _serviceExists = false;

        public WindowsServiceStatusModel(string serviceName)
        {
            _serviceName = serviceName;
        }

        public string ServiceName
        {
            get
            {
                return _serviceName;
            }

            set
            {
                if (_serviceName != value)
                {
                    _serviceName = value;
                    TriggerPropertyChanged(nameof(ServiceName));
                }
            }
        }

        public string DisplayName
        {
            get
            {
                return _displayName;
            }

            set
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    TriggerPropertyChanged(nameof(DisplayName));
                }
            }
        }

        public bool IsServiceEnabled
        {
            get
            {
                return _isServiceEnabled;
            }

            set
            {
                _isServiceEnabled = value;
                TriggerPropertyChanged(nameof(IsServiceEnabled));
            }
        }

        public bool ServiceExists
        {
            get
            {
                return _serviceExists;
            }

            set
            {
                if (_serviceExists != value)
                {
                    _serviceExists = value;
                    TriggerPropertyChanged(nameof(ServiceExists));
                }
            }
        }
    }
}
