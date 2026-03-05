using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TreeView_Binding
{
    public class ModelFisierDirector : INotifyPropertyChanged
    {
        public string Name { get; }
        public string FullPath { get; }
        public bool IsDirectory { get; }

        public ObservableCollection<ModelFisierDirector> Items { get; }

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                NotifyPropertyChanged();
                if (value)
                    LoadChildren();
            }
        }

        public ModelFisierDirector(string path)
        {
            FullPath = path;
            Name = string.IsNullOrEmpty(Path.GetFileName(path)) ? path : Path.GetFileName(path);
            IsDirectory = Directory.Exists(path);
            Items = new ObservableCollection<ModelFisierDirector>();
            if (IsDirectory)
                Items.Add(null);
        }

        private void LoadChildren()
        {
            if (!IsDirectory)
                return;
            if (Items.Count == 1 && Items[0] == null)
                Items.Clear();
            try
            {
                foreach (var dir in Directory.GetDirectories(FullPath));
                   //Incarca directoare
                foreach (var file in Directory.GetFiles(FullPath)) ;
                   //Incarca fisiere
            }
            catch 
            {
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
