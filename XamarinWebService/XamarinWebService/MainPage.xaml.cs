using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MySql.Data.MySqlClient;

namespace XamarinWebService
{
    public partial class MainPage : ContentPage
    {
        RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        private void Button_Clicked(object sender, EventArgs e)
        {
            //List<Repository> repositories = await _restService.GetRepositoriesAsync(Constants.GitHubReposEndpoint);
            //collectionView.ItemsSource = repositories;
            string cs = @"server=localhost;userid=root;password=;database=stockkip_db";
            var con = new MySqlConnection(cs);
            con.Open();
            Console.WriteLine($"MySQL version : {con.ServerVersion}");
            label.Text = "test";
        }
    }
}