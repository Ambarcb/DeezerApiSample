using ApiTests.Models;
using ApiTests.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ApiTests.ViewModels
{
    public class ArtistInfoPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        IDeezerApiService _deezerApiService = new DeezerApiService();
        public ICommand GetArtistInfoCommand { get; set; }
        public Artist ArtistInfo { get; set; }
        const string TitleText = "Connection error";
        const string MessageText = "There was a problem with your internet connection.Please check your network connection, then try again";
        const string OptionButtonText = "Ok";  
        public string Id { get; set; }


        public ArtistInfoPageViewModel()
        {
            GetArtistInfoCommand = new Command(async() =>
            {
               await GetDataAsync();
            });
               
                    
                    
        }

        async Task GetDataAsync()
        {
            if (await CheckInternetConnection())
            {
                try
                {

                    ArtistInfo = await _deezerApiService.GetArtistInfo(Id);
                   
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }
            }
            
        }

        public async Task<bool> CheckInternetConnection()
        {
            bool IsInternetAvailable = true;
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                IsInternetAvailable = false;
                await App.Current.MainPage.DisplayAlert($"{TitleText}", $"{MessageText}", $"{OptionButtonText}");
            }
            return IsInternetAvailable;
        }
        

    }
}
