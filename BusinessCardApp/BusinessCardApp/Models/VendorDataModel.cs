using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCardApp.Models
{
    public class VendorDataModel
    {
        public string VendorName { get; set; }       

        public int Requests { get; set; }

        public VendorDataModel(string name, int value)
        {
            VendorName = name;
            Requests = value;
        }

        public VendorDataModel(string name, int value, bool isSummary)
        {
            VendorName = name;
            Requests = value;
        }
    }
}
