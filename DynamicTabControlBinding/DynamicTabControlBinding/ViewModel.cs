using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabControlBinding
{
    class ViewModel
    {
        public ObservableCollection<MyTab> Tabs { get; set; }

        public ViewModel()
        {
            Tabs = new ObservableCollection<MyTab>
            {
                new MyTab()
                {
                    Header = "Tab 1",
                    Data = new ObservableCollection<MyTabData>()
                    {
                        new MyTabData()
                        {
                            Column1 = "Hello",
                            Column2 = "Hello1",
                            Column3 = "Hello2"
                        },
                        new MyTabData()
                        {
                            Column1 = "World",
                            Column2 = "World1",
                            Column3 = "World2"
                        },
                        new MyTabData()
                        {
                            Column1 = "Test",
                            Column2 = "Test1",
                            Column3 = "Test2"
                        }
                    }
                },
                new MyTab()
                {
                    Header = "Tab 2",
                    Data = new ObservableCollection<MyTabData>()
                    {
                        new MyTabData()
                        {
                            Column1 = "a",
                            Column2 = "b",
                            Column3 = "c"
                        },
                        new MyTabData()
                        {
                            Column1 = "d",
                            Column2 = "e",
                            Column3 = "f"
                        },
                        new MyTabData()
                        {
                            Column1 = "g",
                            Column2 = "h",
                            Column3 = "i"
                        }
                    }
                }
            };
        }
    }
}
