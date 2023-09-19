using System.Windows;

namespace DummyTest
{
    public partial class MainWindow : Window
    {
        MainVM Vm { get; set; }

        public MainWindow()
        {
            Vm = new MainVM();
            DataContext = Vm;
            InitializeComponent();
        }
    }
}
