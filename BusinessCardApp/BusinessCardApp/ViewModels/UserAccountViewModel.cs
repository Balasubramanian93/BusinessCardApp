using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessCardApp.ViewModels
{
    public class UserAccountViewModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _mobileNumber;
        private string _emailID;
        private string _company;
        public event PropertyChangedEventHandler PropertyChanged;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                NotifyPropertyChanged();
            }
        }

        public string MobileNumber
        {
            get
            {
                return _mobileNumber;
            }
            set
            {
                _mobileNumber = value;
                NotifyPropertyChanged();
            }
        }

        public string EmailID
        {
            get
            {
                return _emailID;
            }
            set
            {
                _emailID = value;
                NotifyPropertyChanged();
            }
        }

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
                NotifyPropertyChanged();
            }
        }
        public UserAccountViewModel()
        {
            _userName = "John Peter";
            _mobileNumber = "9876543210";
            _emailID = "peterjohn@gmail.com";
            _company = "Dell";
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
