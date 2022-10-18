using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZimLabs.WpfBase.NetCore;

namespace Demo;

internal class MainWindowViewModel : ObservableObject
{
    private bool _buttonEnabled;

    public bool ButtonEnabled
    {
        get => _buttonEnabled;
        set => SetField(ref _buttonEnabled, value);
    }

    public ICommand ChangeButtonStateCommand => new DelegateCommand(ChangeButtonState);

    private void ChangeButtonState()
    {
        ButtonEnabled = !ButtonEnabled;
    }
}