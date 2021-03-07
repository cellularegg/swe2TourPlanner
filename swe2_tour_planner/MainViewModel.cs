using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace swe2_tour_planner
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _output = "Enter Text to display...";
        private string _input;

        public string Input
        {
            get
            {
                Debug.WriteLine("Read Input.");
                return _input;
            }
            set
            {
                Debug.WriteLine("Write Input.");
                if (Input != value)
                {
                    Debug.WriteLine("Setting Input value.");
                    _input = value;

                    // This triggers the UI and the Execute Command
                    Debug.WriteLine($"Fire propertyChanged: {nameof(Input)}");
                    OnPropertyChanged(nameof(Input));
                }
            }
        }

        public string Output
        {
            get
            {
                Debug.WriteLine("Read Output.");
                return _output;
            }
            set
            {
                Debug.WriteLine("Write Output.");
                if (_output != value)
                {
                    Debug.WriteLine("Setting Output.");
                    _output = value;
                    Debug.WriteLine($"Fire propertyChanged: {nameof(Output)}");
                    OnPropertyChanged(nameof(Output));
                }
            }
        }

        public ICommand DisplayTextCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            Debug.WriteLine("ctor MainViewModel");
            this.DisplayTextCommand = new DisplayTextCommand(this);
            // this.DisplayTextCommand = new RelayCommand(() => Output = $"text enteredb: {Input}");
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Debug.Print($"propertyChanged \"{propertyName}\"");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
