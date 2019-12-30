using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessCardApp.ViewModels
{
    public class BusinessCardDetailsPageViewModel : INotifyPropertyChanged
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Field
        private string _employeeID;
        private string _department;
        private string _location;
        private string _designation;
        private string _emailID;
        private string _fax;
        private string _telephone;
        private string _mobileNumber;
        private string _address;
        private int _noOfCards;
        private string _remarks;
        private List<string> _vendorsList;
        private List<string> _statusList;
        private string _approvalRemarks;
        private int _selectedIndex = 0;
        #endregion

        #region Properties

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
            }
        }
        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
                NotifyPropertyChanged();
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
                NotifyPropertyChanged();
            }
        }
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                _designation = value;
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
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                NotifyPropertyChanged();
            }
        }

        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
                NotifyPropertyChanged();
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
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

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged();
            }
        }
        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
                NotifyPropertyChanged();
            }
        }
        public string ApprovalRemarks
        {
            get
            {
                return _approvalRemarks;
            }
            set
            {
                _approvalRemarks = value;
                NotifyPropertyChanged();
            }
        }
        public int NoOfCards
        {
            get
            {
                return _noOfCards;
            }
            set
            {
                _noOfCards = value;
                NotifyPropertyChanged();
            }
        }
        public List<string> VendorsList
        {
            get
            {
                return _vendorsList;
            }
            set
            {
                _vendorsList = value;
                NotifyPropertyChanged();
            }
        }
        public List<string> StatusList
        {
            get
            {
                return _statusList;
            }
            set
            {
                _statusList = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Methods

        public void NotifyPropertyChanged([CallerMemberName] string propertyName= null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public BusinessCardDetailsPageViewModel()
        {
            _statusList = new List<string>() { "In Progress", "On Hold" , "Closed", "Assign" };
            _vendorsList = new List<string>() { "LG", "Dell", "Asus", "Microsoft", "Infosys" };
            _employeeID = "1234";
            _emailID = "peterjohn@gmail.com";
            _designation = "Engineer";
            _department = "IT";
            _address = "San Fransico";
            _fax = "098675433254";
            _location = "San Fransico";
            _mobileNumber = "9876543210";
            _noOfCards = 30;
            _remarks = "";
            _telephone = "+09656536567";

        }

        #endregion


    }
}
