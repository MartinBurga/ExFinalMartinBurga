using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.ViewModels
{
    class RegistrosViewModel : INotifyPropertyChanged
    {
        private string _logs;
        public string Logs
        {
            get => _logs;
            set { _logs = value; OnPropertyChanged(nameof(Logs)); }
        }

        public RegistrosViewModel()
        {
            LeerLogs();
        }

        private void LeerLogs()
        {
            string logPath = Path.Combine(FileSystem.AppDataDirectory, "Martin.txt");

            if (File.Exists(logPath))
                Logs = File.ReadAllText(logPath);
            else
                Logs = "No existen logs...";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
