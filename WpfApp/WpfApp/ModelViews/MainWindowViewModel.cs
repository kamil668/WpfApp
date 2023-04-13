using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            NwdCommand = new RelayCommand(nwd);
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

        private string header;

        public string Header
        {
            get { return header; }
            set
            {
                header = value;
                OnPropertyChanged(nameof(Header));
            }
        }

        private string arg2;

        public string Arg2
        {
            get { return arg2; }
            set
            {
                arg2 = value;
                OnPropertyChanged(nameof(Arg2));
            }
        }

        public ICommand IloczynCommand { get; set; }
        public ICommand NwdCommand { get; set; }
        
        public void nwd(Object obj)
        {
            try
            {
                double a = Convert.ToDouble(Arg1);
                double b = Convert.ToDouble(Arg2);

                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                Header = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
