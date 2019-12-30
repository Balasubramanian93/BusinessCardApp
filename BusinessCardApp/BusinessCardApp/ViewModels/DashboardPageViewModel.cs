using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BusinessCardApp.Models;
using System.Runtime.CompilerServices;

namespace BusinessCardApp.ViewModels
{
    public class DashboardPageViewModel : INotifyPropertyChanged
    {
        private List<string> _vendorList;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<VendorDataModel> VendorData { get; set; }

        public ObservableCollection<StatusDataModel> StatusData { get; set; }

        public List<string> VendorList
        {
            get
            {
                return _vendorList;
            }
            set
            {
                _vendorList = value;
                NotifyPropertyChanged();
            }
        }
        public DashboardPageViewModel()
        {
            _vendorList = new List<string>()
            {
                "All",
                "HP",
                "Dell",
                "Infosys",
                 "Microsoft",
                 "Ramco",
                 "Asus"
            };


            VendorData = new ObservableCollection<VendorDataModel>
            {
                new VendorDataModel("HP", 30),
                new VendorDataModel("Dell", 35),
                new VendorDataModel("Infosys", 24),
                new VendorDataModel("Microsoft", 11),
                new VendorDataModel("Ramco", 25),
                new VendorDataModel("Asus", 39),
           };


            StatusData = new ObservableCollection<StatusDataModel>
            {
                new StatusDataModel("Approved",10),
                new StatusDataModel("Pending",15),
                new StatusDataModel("Open",4),

            };
        }
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
