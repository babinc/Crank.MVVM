#Crank MVVM
##Install Using:
    PM> Install-Package Crank.MVVM
##NuGet Page:
[Crank.MVVM](https://www.nuget.org/packages/Crank.MVVM)
##Features:
####No Magic Strings When Binding Properties
```C#
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
```
####View Model Locator
```C#
    var example = VMLocator.OtherVM.MyProperty;
```
####Simple Commands
```C#
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

    private bool CanTest(object obj)
    {
        return true;
    }

    private void TestExecute(object obj)
    {
         
    }
```
