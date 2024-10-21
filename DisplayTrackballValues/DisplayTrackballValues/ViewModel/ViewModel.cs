using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTrackballValues
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            DateTime startDate = new DateTime(2000, 01, 04);
            DateTime endDate = new DateTime(2000, 09, 05);
            Data.Add(new Model() { YValue1 = 5,  YValue2 = 5,  YValue3 = 5,  Date = new DateTime(2001, 01, 05) });
            Data.Add(new Model() { YValue1 = 10, YValue2 = 15, YValue3 = 13, Date = new DateTime(2001, 03, 06) });
            Data.Add(new Model() { YValue1 = 15, YValue2 = 20, YValue3 = 25, Date = new DateTime(2001, 05, 07) });
            Data.Add(new Model() { YValue1 = 10, YValue2 = 15, YValue3 = 20, Date = new DateTime(2001, 07, 08) });
            Data.Add(new Model() { YValue1 = 25, YValue2 = 20, YValue3 = 35, Date = new DateTime(2001, 09, 09) });
            Data.Add(new Model() { YValue1 = 35, YValue2 = 40, YValue3 = 50, Date = new DateTime(2001, 11, 10) });

        }
    }
}
