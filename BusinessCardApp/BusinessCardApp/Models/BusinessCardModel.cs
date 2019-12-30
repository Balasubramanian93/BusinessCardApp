using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCardApp.Models
{
    public class BusinessCardModel
    {
        private string _name;
        private int _noofRequest;
        private string _status;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int NoOfRequest
        {
            get
            {
                return _noofRequest;
            }
            set
            {
                _noofRequest = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public BusinessCardModel(string name, int noofrequest, string status)
        {
            _name = name;
            _noofRequest = noofrequest;
            _status = status;
        }
    }
}
