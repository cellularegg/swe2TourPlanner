using System;
using System.Diagnostics;
using System.Windows.Input;

namespace swe2_tour_planner
{
    public class DisplayTextCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public DisplayTextCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _mainViewModel.PropertyChanged += (sender, args) =>
            {
                Debug.WriteLine("Command: received prop changed");
                if (args.PropertyName == "Input")
                {
                    Debug.WriteLine("Command received prop changed of Input");
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            };
        }


        public bool CanExecute(object? parameter)
        {
            Debug.WriteLine("Command: can execute.");
            return !string.IsNullOrWhiteSpace(_mainViewModel.Input);
        }

        public void Execute(object? parameter)
        {
            Debug.WriteLine("Command execute");
            _mainViewModel.Output = $"Text entered: \"{_mainViewModel.Input}\"";
            // _mainViewModel.Input = string.Empty;
            Debug.WriteLine("Command: execute done");
        }

        public event EventHandler? CanExecuteChanged;
    }
}