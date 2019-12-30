using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCardApp.Models
{
    public class StatusDataModel
    {
        public string Status { get; set; }       

        public int StatusCount { get; set; }

        public StatusDataModel(string status, int statusCount)
        {
            Status = status;
            StatusCount = statusCount;
        }
   }
}
