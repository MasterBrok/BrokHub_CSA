

using BrokHub_CSA.BackendApplication.BaseICommand;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace BrokHub_CSA.BackendApplication.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Notyfi(string Target)
        {
            if (PropertyChanged is not null)
                PropertyChanged(this, new PropertyChangedEventArgs(Target));
        }

        private ICommand _cmdSelectPage;

        public ICommand CmdSelectMenuItem
        {
            set { _cmdSelectPage = value; }
            get
            {
                if (_cmdSelectPage == null)
                    _cmdSelectPage = new BrokCommand(SelectPage_Click, CanSelectPage_Click);
                return _cmdSelectPage;
            }
        }


        private Uri _uripage;

        public Uri UriPage
        {
            get { return _uripage; }
            set
            {
                _uripage = value;
                Notyfi(nameof(UriPage));
            }
        }

        public MainViewModel()
        {
                
        }

        private bool CanSelectPage_Click(object obj)
        {
            return true;
        }

        private void SelectPage_Click(object obj)
        {
            switch (obj.ToString())
            {
                case "Home":
                    UriPage = new Uri("\\Pages\\pgHome.xaml",UriKind.Relative);
                    break;
                case "Developer":
                    UriPage = new Uri("\\Pages\\pgDeveloper.xaml", UriKind.Relative);
                    break;
                case "Convert":
                    UriPage = new Uri("\\Pages\\pgConvert.xaml", UriKind.Relative);
                    break;
                default:
                    UriPage = new Uri("\\Pages\\pgHome.xaml", UriKind.Relative);
                    break;
            }
        }
    }
}
