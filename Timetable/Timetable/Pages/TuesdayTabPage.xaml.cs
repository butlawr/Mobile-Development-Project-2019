﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timetable.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TuesdayTabPage : ContentPage
	{
        // Variables
        // View Model
        ModuleViewModel _viewModel;
        private string dayOfWeek = "Tuesday";

        public TuesdayTabPage ()
		{
			InitializeComponent ();

            // New instances of ViewModel class and setting the it as the binding context
            _viewModel = new ModuleViewModel();
            BindingContext = _viewModel;

            listOfModules.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                // Set selected module from listview
                var selectedModule = e.SelectedItem as Module;
                // Navigate to create page to edit it.
                Navigation.PushAsync(new CreatePage(selectedModule, dayOfWeek, false));
            };

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var module = new Module();
            // Navigate to create page passing Module instances to populate the object as 
            // well as the day of the week and 'true' that the module is a new entry.
            Navigation.PushAsync(new CreatePage(module, dayOfWeek, true));
        }

        // Function to fetch all data when the page appears.
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.GetModulesByDayOfWeek(dayOfWeek);
        }
    }
}