using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExpenseTracker.Models;

namespace TravelExpenseTracker.ViewModels;

public partial class TripsViewModel : ObservableObject
{
    public ObservableCollection<TripModel> Trips { get; set;} = [];
    [RelayCommand]
    private void AddTripTemp()
    {
        Trips.Add(new TripModel("logo.png", "Trip 1", "Some Location"));
        Trips.Add(new TripModel("logo.png", "Trip 2", "Some other Location"));
        Trips.Add(new TripModel("logo.png", "Trip 3", "Some same Location"));
        Trips.Add(new TripModel("logo.png", "Trip 4", "Some some end Location"));
    }

}
