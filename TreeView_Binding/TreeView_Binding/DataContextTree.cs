using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_Binding
{
    class DataContextTree
    {
        public ObservableCollection<ModelFisierDirector> Partitii { get; }
        public DataContextTree()
        {
            Partitii = new ObservableCollection<ModelFisierDirector>();
            foreach (var drive in DriveInfo.GetDrives())
                Partitii.Add(new ModelFisierDirector(drive.Name));
        }
    }
}
