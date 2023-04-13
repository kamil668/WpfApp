using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Commands;
 

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            IloczynCommand = new RelayCommand(iloczyn);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string arg1;
        public string Arg1
        {
            get { return arg1; }
            set
            {
                arg1 = value;
                OnPropertyChanged(nameof(Arg1));
            }
        }
        public ICommand IloczynCommand { get; set; }
        public void iloczyn(Object obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
