using System.Collections.ObjectModel;

namespace DummyTest
{
    public class MainVM
    {
        public ObservableCollection<Object> Objects { get; set; }

        public MainVM()
        {
            Objects = new ObservableCollection<Object>();
            Object obj1 = new Object();
            obj1.HasColors = true;
            obj1.ApplyColors = false;
            Objects.Add(obj1);
            Object obj2 = new Object();
            obj2.HasColors = false;
            obj2.ApplyColors = false;
            Objects.Add(obj2);
        }
    }
}
