using System.ComponentModel;
using System.Diagnostics;

namespace DummyTest
{
    public class Object : INotifyPropertyChanged
    {
        public bool HasColors { get; set; }
        private bool _applyColors { get; set; }
        public bool ApplyColors
        {
            get => _applyColors;
            set
            {
                Debug.WriteLine("Setting color!");
                if (value == _applyColors)
                {
                    return;
                }

                _applyColors = value;
                OnPropertyChanged("ApplyColors");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
