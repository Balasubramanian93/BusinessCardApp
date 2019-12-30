using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BusinessCardApp.Models;

namespace BusinessCardApp.ViewModels
{
    public class BusinessCardListViewModel 
    {
        public ObservableCollection<BusinessCardModel> BusinessCardListData { get; set; }

        public BusinessCardListViewModel()
        {
            BusinessCardListData = new ObservableCollection<BusinessCardModel>();
            BusinessCardListData.Add(new BusinessCardModel("John Peter", 30, "Pending"));
            BusinessCardListData.Add(new BusinessCardModel("Michael Starc", 30, "Inprogress"));
            BusinessCardListData.Add(new BusinessCardModel("Steve Smith", 15, "Completed"));
            BusinessCardListData.Add(new BusinessCardModel("John Williams", 20, "Open"));
           



        }
    }
}
