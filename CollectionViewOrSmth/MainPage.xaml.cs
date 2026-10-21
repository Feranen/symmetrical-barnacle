using System.Collections.ObjectModel;

namespace CollectionViewOrSmth
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> uc = [];

        public MainPage()
        {
            InitializeComponent();
            Uc.ItemsSource = uc;
        }


        private void GetDataFromEntry(object? sender, EventArgs e)
        {
            string EntryText = Entr.Text;
            if (!string.IsNullOrEmpty(EntryText))
            {
                uc.Add(Entr.Text);
            }
        }
        private void DeleteData(object? sender, EventArgs e)
        {
            uc.Clear();
        }
        private void DeleteLastData(object? sender, EventArgs e)
        {
            if (uc.Count > 0)
            {
                uc.RemoveAt(uc.Count - 1);
            }
        }
        //Test
    }
}
