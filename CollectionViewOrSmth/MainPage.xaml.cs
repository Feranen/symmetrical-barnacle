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
            uc.Add(Entr.Text);
        }
        private void DeleteData(object? sender, EventArgs e)
        {
            uc.Clear();
        }
    }
}
