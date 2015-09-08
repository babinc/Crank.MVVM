using CrankSample.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrankSample.ViewModels
{
    public class MainViewModel : NotifyBase
    {
        #region Fields
        #endregion

        #region Properties
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                base.RaisePropertyChanged(() => Title);
            }
        }
        #endregion

        #region Commands
        private RelayCommand _testCommand;
        public ICommand TestCommand
        {
            get
            {
                if (_testCommand == null)
                {
                    _testCommand = new RelayCommand(TestExecute, CanTest);
                }
                return _testCommand;
            }
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Title = "Project Title";
        }
        #endregion

        #region Methods
        private bool CanTest(object obj)
        {
            return true;
        }

        private void TestExecute(object obj)
        {
            
        }
        #endregion
    }
}
