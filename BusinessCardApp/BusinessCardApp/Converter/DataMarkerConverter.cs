using BusinessCardApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace BusinessCardApp.Converter
{
    public class DataMarkerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null && parameter.ToString() == "Label")
            {
                if (value is List<object>)
                {
                    return "Others";
                }
                else
                {
                    if (value != null)
                    {
                        return (value as VendorDataModel).VendorName;
                    }
                }
            }
            else if(parameter != null && parameter.ToString() == "Status")
            {
                if (value is List<object>)
                {
                    return "Others";
                }
                else if (value != null)
                {
                    return (value as StatusDataModel).Status;
                }
            }
            else
            {
                if (value is List<object>)
                {
                    return (value as List<object>).Sum((item => item is VendorDataModel ? (item as VendorDataModel).Requests: (item as StatusDataModel).StatusCount)).ToString();
                }
                else
                {
                    if (value != null)
                    {
                        if (value is VendorDataModel)
                            return (value as VendorDataModel).Requests;
                        else
                            return (value as StatusDataModel).StatusCount;
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
