using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExpenseTracker.Pages;

namespace TravelExpenseTracker.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty] //UserName
    private string _username;
    [ObservableProperty]
    private string _password;

    [RelayCommand]
    private async Task NavigateToRegisterAsync() =>
        await Shell.Current.GoToAsync(nameof(RegisterPage));

    [RelayCommand]
    private async Task LoginAsync()
    {
    //Loginvalidation
    //call the api
    //redirect to home/ main page
    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
