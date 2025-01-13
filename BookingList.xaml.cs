namespace HotelBookingApp;
using HotelBookingApp.Models;
public partial class BookingList : ContentPage
{
	public BookingList()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Booking)BindingContext;
        slist.CheckInDate = DateTime.UtcNow;
        await App.Database.SaveBookingAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Booking)BindingContext;
        await App.Database.DeleteBookingListAsync(slist);
        await Navigation.PopAsync();
    }

}