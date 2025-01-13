using HotelBookingApp.Data;
using HotelBookingApp.Models;
namespace HotelBookingApp;

public partial class ListEntryPage : ContentPage
{
	public ListEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetBookingListsAsync();
    }
    async void OnBookingAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BookingList
        {
            BindingContext = new Booking()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new BookingList
            {
                BindingContext = e.SelectedItem as Booking
            });
        }
    }

}