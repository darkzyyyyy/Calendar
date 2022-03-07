using CustomCalendarControl.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCalendar_Clicked(object sender, EventArgs e)
        {
            var calendarPage = new CalendarPage(DateTime.Now, null);
            calendarPage.SelectedDateCommand = new Command<DateTime>((item) =>
            {
                lblDate.Text = item.ToString("dd MMM yyyy");
            });
            await PopupNavigation.Instance.PushAsync(calendarPage);
        }
       
    }
}
