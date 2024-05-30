using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03MOD05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            DateTime birthdate = birthDatePicker.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            result.Text = age.ToString();
        }
    }
}
