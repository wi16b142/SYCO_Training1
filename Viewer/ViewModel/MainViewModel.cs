using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Viewer.SR_Person;


namespace Viewer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Data> data;

        
        public ObservableCollection<Data> Data
        {
            get { return data; }
            set { data = value; RaisePropertyChanged(); }
        }
        

        public MainViewModel()
        {
            Service_PersonClient client = new Service_PersonClient();
            Data = new ObservableCollection<Data>(client.QueryAllData());
        }
    }
}