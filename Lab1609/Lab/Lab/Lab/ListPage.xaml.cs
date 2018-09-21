using Lab.Data;
using Lab.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab
{
    public partial class MainPage : ContentPage
    {
        DataRetriever data;
        private ObservableCollection<User> userCollection = new ObservableCollection<User>();

        public MainPage()
        {
            InitializeComponent();
            Title = "Users";
            data = new DataRetriever();
            UsersListView.ItemsSource = userCollection;
        }

        public ObservableCollection<User> getUserCollection()
        {
            return userCollection;
        }

        public void populateData()
        {

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
