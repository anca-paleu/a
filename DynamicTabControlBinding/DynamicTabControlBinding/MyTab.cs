using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabControlBinding
{
    class MyTab
    {
        public string Header { get; set; }
        public ObservableCollection<MyTabData> Data { get; set; } = new ObservableCollection<MyTabData>();
    }
}
